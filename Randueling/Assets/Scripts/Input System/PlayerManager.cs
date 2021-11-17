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

    }

    public void OnPlayerJoined()
    {
        GameObject playerToFind;

        Debug.Log("Player Joined");
        if(playerCount == 0)
        {
            Debug.Log("Player One");
            playerCount++;

            playerToFind = GameObject.FindGameObjectWithTag("PlayerOne"); //finds the player in the scene, this will have the control scheme information needed to play

            playerOne = playerToFind;
            DontDestroyOnLoad(playerOne);

            playerPrefab.gameObject.tag = "PlayerTwo";
            pInputManager.playerPrefab = playerPrefab;
        }
        else if(playerCount == 1)
        {
            Debug.Log("Player Two");

            playerToFind = GameObject.FindGameObjectWithTag("PlayerTwo");

            playerTwo = playerToFind;
            DontDestroyOnLoad(playerTwo);
        }
        else
        {
            Debug.Log("Invalid Number Of Players");
        }
    }

    public void StartGame()
    {
        if (!sceneChanged)
        {
            Debug.Log("Button Pressed");
            sceneChanged = true;
            SceneManager.LoadScene(1);
        }
    }

}
