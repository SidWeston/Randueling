using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWeaponSelection : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    public List<GameObject> weaponsList;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
