using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class WinningPlayer : MonoBehaviour
{

    public GameObject playerManager;

    public GameObject playerOneWin;
    public GameObject playerTwoWin;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager");

        playerManager.GetComponent<PlayerInputManager>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!playerManager)
        {
            playerManager = GameObject.FindGameObjectWithTag("PlayerManager");
        }
        else
        {
            DecideWinner();
        }
    }


    private void DecideWinner()
    {
        if(playerManager.GetComponent<PlayerManager>().winningPlayerIndex == 1)
        {
            playerOneWin.SetActive(true);
            playerTwoWin.SetActive(false);
        }
        else
        {

            playerOneWin.SetActive(false);
            playerTwoWin.SetActive(true);
        }
    }

}
