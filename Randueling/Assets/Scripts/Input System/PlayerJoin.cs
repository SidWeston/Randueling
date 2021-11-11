using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class PlayerJoin : MonoBehaviour
{

    public GameObject[] playerStartLocation;
    public List<GameObject> players;
    public PlayerInputManager pInputManager;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    public void OnPlayerJoined()
    {

        GameObject playerToAdd;
        if(players.Count == 0) //if there are no players in the scene
        {
            playerToAdd = GameObject.FindGameObjectWithTag("Player1");
            players.Add(playerToAdd);
        }
        else
        {
            playerToAdd = GameObject.FindGameObjectWithTag("Player2");
            players.Add(playerToAdd);
        }
    }

}
