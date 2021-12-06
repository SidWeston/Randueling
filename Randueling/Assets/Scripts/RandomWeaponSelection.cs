using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomWeaponSelection : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    public List<GameObject> weaponsList;
    public List<GameObject> weaponSelectPrefabs;
    public List<GameObject> playerOneWeapons;
    public List<GameObject> playerTwoWeapons;

    [SerializeField]
    private float startDistance = -580.0f;
    [SerializeField]
    private float gapDistance = 230.0f;
    [SerializeField]
    private MenuScript player1Menu;
    [SerializeField]
    private MenuScript player2Menu;

    private bool currentUISet = false;
    private bool currentUISet2 = false;


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
            GenerateWeaponChoice(playerOneWeapons,1);
        }
        //SetPlayerWeapon(playerOne, playerOneWeapons[0]);
        for (int i = 0; i < 3; i++)
        {
            GenerateWeaponChoice(playerTwoWeapons,2);
        }
        //SetPlayerWeapon(playerTwo, playerTwoWeapons[0]);
        
    }

    public void GenerateWeaponChoice(List<GameObject> listToAddTo,int playerNumber)
    {
        bool wepAdded = false;
        int weaponIndexToAdd = Random.Range(0, weaponsList.Count);
        if(listToAddTo.Count >= 1)
        {
            listToAddTo.Add(weaponsList[weaponIndexToAdd]);
            if (CheckForWeaponDuplicates(listToAddTo))
            {
                listToAddTo.RemoveAt(listToAddTo.Count - 1);
                GenerateWeaponChoice(listToAddTo,playerNumber);
            }
            else
            {
                wepAdded = true;
            }
        }
        else
        {
            listToAddTo.Add(weaponsList[weaponIndexToAdd]);
            wepAdded = true;
        }
        if (wepAdded)
        {
            GameObject newUI = Instantiate(weaponSelectPrefabs[weaponIndexToAdd],GameObject.FindGameObjectWithTag("Canvas").transform);
            newUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(startDistance,0);
            if(playerNumber == 1)
            {
                newUI.GetComponent<Button>().onClick.AddListener(() => { SetPlayerWeapon(weaponIndexToAdd, "PlayerOne"); });
                newUI.tag = "Button";
                if (!currentUISet)
                {
                    player1Menu.currentSelection = newUI;
                    currentUISet = true;
                }
            }
            else
            {
                newUI.GetComponent<Button>().onClick.AddListener(() => { SetPlayerWeapon(weaponIndexToAdd, "PlayerTwo"); });
                newUI.tag = "Button2";
                if (!currentUISet2)
                {
                    player2Menu.currentSelection = newUI;
                    currentUISet2 = true;
                }
            }
            
            startDistance += gapDistance;
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

    public void SetPlayerWeapon(int playerWeapon, string playerToAddTo)
    {
        GameObject chosenWeapon = weaponsList[playerWeapon];
        GameObject chosenPlayer = GameObject.FindGameObjectWithTag(playerToAddTo);
        Transform weaponPos = chosenPlayer.GetComponent<PlayerWeapon>().weaponLocation.transform;
        GameObject weapon = Instantiate(chosenWeapon, weaponPos.position + chosenWeapon.transform.position, transform.rotation, chosenPlayer.transform);
        weapon.transform.Rotate(0, -8.68f, 0);
        chosenPlayer.GetComponent<PlayerWeapon>().currentWeapon = weapon;
    }
    

}
