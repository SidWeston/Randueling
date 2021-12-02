using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWeaponSelection : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    public List<GameObject> weaponsList;
    public List<GameObject> playerOneWeapons;
    public List<GameObject> playerTwoWeapons;


    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");

        GenerateRandomWeapons();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerOne == null)
        {
            playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        }
        if(playerTwo == null)
        {
            playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");
        }
    }

    public void GenerateRandomWeapons()
    {
        for (int i = 0; i < 3; i++)
        {
            playerOneWeapons.Add(weaponsList[Random.Range(0, weaponsList.Count)]);
        }
        for (int i = 0; i < 3; i++)
        {
            playerTwoWeapons.Add(weaponsList[Random.Range(0, weaponsList.Count)]);
        }
    }

}
