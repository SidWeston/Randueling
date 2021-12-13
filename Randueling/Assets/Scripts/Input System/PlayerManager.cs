using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private bool sceneChanged = false;

    public PlayerInputManager pInputManager;
    private int playerCount;

    //prefabs for the players, set up with the correct control schemes
    public GameObject playerPrefab;

    public GameObject playerOne, playerTwo;

    private int currentSceneIndex = 1;
    private float sceneChangeCooldown = 2.0f;

    public float winningPlayerIndex;

    //UI Stuff
    //public Image controllerConnected;
    //public Image mkConnected;
    //public RectTransform playerOneConnectLocation;
    //public RectTransform playerTwoConnectLocation;

    // Start is called before the first frame update
    void Start()
    {
        playerPrefab.gameObject.tag = "PlayerOne";
        pInputManager.playerPrefab = playerPrefab;

        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneChanged)
        {
            sceneChangeCooldown -= Time.deltaTime;
            if(sceneChangeCooldown <= 0)
            {
                sceneChanged = false;
            }
        }
    }

    public void OnPlayerJoined()
    {
        GameObject playerToFind;

        if(playerCount == 0) //player one
        {
            playerCount++;

            playerToFind = GameObject.FindGameObjectWithTag("PlayerOne"); //finds the player in the scene, this will have the control scheme information needed to play

            playerOne = playerToFind;
            DontDestroyOnLoad(playerOne);
            playerOne.GetComponent<PlayerMovement>().invertXClamp = false;
            
            playerPrefab.gameObject.tag = "PlayerTwo";
            pInputManager.playerPrefab = playerPrefab;
        }
        else if(playerCount == 1) //player two
        {
            playerToFind = GameObject.FindGameObjectWithTag("PlayerTwo");

            playerTwo = playerToFind;
            DontDestroyOnLoad(playerTwo);
            playerTwo.GetComponent<PlayerMovement>().invertXClamp = true;


            StartGame();

        }
        else
        {
            Debug.Log("Invalid Number Of Players");
        }
    }

    public void StartGame()
    {
        if(!sceneChanged)
        {
            if (currentSceneIndex == 1) //bool stops the scene from being reset during play
            {
                sceneChanged = true;
                currentSceneIndex = 2;
                SceneManager.LoadScene(2);
                //playerOne.GetComponent<PlayerInput>().Disable();
                //playerTwo.GetComponent<PlayerInput>().Disable();
            }
            else if (currentSceneIndex == 2)
            {
                sceneChanged = true;
                currentSceneIndex = 3;
                //playerOne.GetComponent<PlayerInput>().Enable();
                //playerTwo.GetComponent<PlayerInput>().Enable();
                playerOne.GetComponent<PlayerMovement>().movementEnabled = true;
                playerTwo.GetComponent<PlayerMovement>().movementEnabled = true;
                SceneManager.LoadScene(3);
            }
        }

    }

    public void WhoWins(int winner)
    {
        winningPlayerIndex = winner;
        Destroy(playerOne);
        Destroy(playerTwo);
    }
}
