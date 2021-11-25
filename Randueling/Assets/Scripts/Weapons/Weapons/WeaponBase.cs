using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{

    //locations where the bullet class can be instantiated
    public GameObject bulletSpawnLocation; //on most weapons, there will only be one location but some weapons will have multiple barrels
    public GameObject bullet; //the bullet that is spawned when the weapon is fired

    public bool doesRichochet; //if the bullet ricochets or not, will be used by the projectile
    //if the weapon is a projectile (bullet has travel time)
    public bool isProjectile = true; //if false, the weapon will fire a raycast instead of a projectile

    public int magazineSize, bulletsLeft, bulletsShot, bulletsPerFire;
    public float spread, timeBetweenShots, bulletVelocity, reloadTime;
    public bool shooting, readyToShoot, reloading;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        readyToShoot = true;
        bulletsLeft = magazineSize;
    }

    // Update is called once per frame
    public virtual void Update()
    {
    }

    //virtual functions to be overridden if needed on specific weapons
    public virtual void FireWeapon(Vector3 directionToFire)
    {

        if (isProjectile && readyToShoot && bulletsLeft > 0)
        {

            readyToShoot = false;
            bulletsLeft--;

            GameObject currentBullet = Instantiate(bullet, bulletSpawnLocation.transform.position, Quaternion.identity);
            currentBullet.transform.forward = directionToFire.normalized;
            //Temp variable to decide bullet owner, change this later!
            GameObject whoFired = this.transform.parent.gameObject;
            if(whoFired.gameObject.tag == "PlayerOne")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 1;
                currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
            }
            else if(whoFired.gameObject.tag == "PlayerTwo")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 2;
                currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
            }

           
            Invoke("ResetShot", timeBetweenShots);

        }
        else if(bulletsLeft == 0)
        {
            Invoke("Reload", reloadTime);
        }
        else
        {
            //TODO: Implement Raycasts
        }

    }

    public virtual void ResetShot()
    {
        readyToShoot = true;
    }

    public virtual void Reload()
    {
        //TODO: add a cooldown on the reload until the reload animation is finished
        bulletsLeft = magazineSize;

    }

}
