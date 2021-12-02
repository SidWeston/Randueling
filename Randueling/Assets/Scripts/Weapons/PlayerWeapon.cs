using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{

    public GameObject currentWeapon; //the weapon the player currently has
    public GameObject weaponLocation;

    //unity input system converts input actions to variables
    private float fireWeapon;
    public GameObject bulletSpawnLocation;

    [SerializeField] private Camera playerCamera; //reference to the player camera to help determine the direction the projectile should fire

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(fireWeapon > 0.1f)
        {

            //Ray rayToScreen = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //creates a ray to the middle of the screen
            //RaycastHit hit;
            //Vector3 targetPoint;

            //if (Physics.Raycast(rayToScreen, out hit))
            //{
            //    targetPoint = hit.point;
            //}
            //else //if false, the player is shooting into the air
            //{
            //    targetPoint = rayToScreen.GetPoint(75); //gets a vector3 point in the direction of the raycast that is far away from the player
            //}
            //Vector3 direction = targetPoint - bulletSpawnLocation.transform.position;

            currentWeapon.GetComponent<WeaponBase>().FireWeapon(bulletSpawnLocation.transform.forward);
        }
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        fireWeapon = context.ReadValue<float>();
    }

}
