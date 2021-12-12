using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartLocations : MonoBehaviour
{

    private GameObject playerManager;

    //game objects to hold references to the player characters
    public GameObject gPlayerOne;
    public GameObject gPlayerTwo;

    //empty game objects to hold the position of the player's spawn locations
    public GameObject playerOneSpawn;
    public GameObject playerTwoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager");

        SetPlayerTransforms();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPlayerTransforms()
    {

        playerManager.GetComponent<PlayerManager>().playerOne.GetComponent<PlayerMovement>().zLocationLock = playerOneSpawn.transform.position.z;
        playerManager.GetComponent<PlayerManager>().playerTwo.GetComponent<PlayerMovement>().zLocationLock = playerTwoSpawn.transform.position.z;
        playerManager.GetComponent<PlayerManager>().playerOne.GetComponent<PlayerMovement>().rotationEnabled = true;
        playerManager.GetComponent<PlayerManager>().playerTwo.GetComponent<PlayerMovement>().rotationEnabled = true;
        playerManager.GetComponent<PlayerManager>().playerOne.GetComponent<PlayerMovement>().invertXClamp = false;
        playerManager.GetComponent<PlayerManager>().playerTwo.GetComponent<PlayerMovement>().invertXClamp = true;

        playerManager.GetComponent<PlayerManager>().playerOne.transform.position = playerOneSpawn.transform.position;
        playerManager.GetComponent<PlayerManager>().playerTwo.transform.position = playerTwoSpawn.transform.position;
        playerManager.GetComponent<PlayerManager>().playerOne.transform.rotation = playerOneSpawn.transform.rotation;
        playerManager.GetComponent<PlayerManager>().playerTwo.transform.rotation = playerTwoSpawn.transform.rotation;
    }


}
