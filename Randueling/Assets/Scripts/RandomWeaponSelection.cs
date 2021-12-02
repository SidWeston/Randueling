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
        //if either of the player prefabs cant be found, attempts to find them again
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
        for(int i = 0; i < 3; i++)
        {
            GenerateWeaponChoice(playerOneWeapons);
           
        }
        SetPlayerWeapon(playerOne, playerOneWeapons[0]);
        for (int i = 0; i < 3; i++)
        {
            GenerateWeaponChoice(playerTwoWeapons);
        }
        SetPlayerWeapon(playerTwo, playerTwoWeapons[0]);
    }

    public void GenerateWeaponChoice(List<GameObject> listToAddTo)
    {
        int weaponIndexToAdd = Random.Range(0, weaponsList.Count);
        if(listToAddTo.Count >= 1)
        {
            listToAddTo.Add(weaponsList[weaponIndexToAdd]);
            if (CheckForWeaponDuplicates(listToAddTo))
            {
                listToAddTo.RemoveAt(listToAddTo.Count - 1);
                GenerateWeaponChoice(listToAddTo);
            }
        }
        else
        {
            listToAddTo.Add(weaponsList[weaponIndexToAdd]);
        }
    }

    public bool CheckForWeaponDuplicates(List<GameObject> listToCheck)
    {
        for(int i = 0; i < listToCheck.Count; i++)
        {
            if(i >= 1)
            {
                if(listToCheck[i].gameObject == listToCheck[i - 1].gameObject)
                {
                    return true;
                }
                else if(i >= 2 && listToCheck[i].gameObject == listToCheck[i - 2].gameObject)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public void SetPlayerWeapon(GameObject playerToAddTo, GameObject playerWeapon)
    {
        GameObject weapon = Instantiate(playerWeapon, playerToAddTo.GetComponent<PlayerWeapon>().weaponLocation.transform.position, transform.rotation, playerToAddTo.transform);
        playerToAddTo.GetComponent<PlayerWeapon>().currentWeapon = weapon;
    }
    

}
