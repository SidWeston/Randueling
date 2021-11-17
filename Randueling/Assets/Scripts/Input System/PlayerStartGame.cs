using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerStartGame : MonoBehaviour
{

    private GameObject playerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartGame(InputAction.CallbackContext context)
    {
        playerManager.GetComponent<PlayerManager>().StartGame();
    }
}
