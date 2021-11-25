using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiAutomaticWeapon : WeaponBase
{
    // Start is called before the first frame update
    void Start()
    {
        readyToShoot = true;
        bulletsLeft = magazineSize;

    }

    // Update is called once per frame
    void Update()
    {
        if(bulletSpawnLocation == null)
        {
            //IMPORTANT!!!
            //THE BULLET SPAWN LOCATION GAME OBJECT IN THE PLAYER PREFAB MUST ALWAYS BE THE FIRST CHILD OBJECT
            //IF IT ISNT THE FIRST CHILD OBJECT THE GAME WILL BREAK
            //IMPORTANT!!!
            //bulletSpawnLocation = transform.parent.GetChild(0).gameObject;
            Debug.Log("bababooey");
        }
    }

    override public void FireWeapon(Vector3 directionToFire, GameObject whoFired)
    {

        if(!readyToShoot && !IsInvoking())
        {
            Invoke("ResetShot", timeBetweenShots);
        }

        if (isProjectile && readyToShoot && bulletsLeft > 0)
        {
            readyToShoot = false;
            bulletsLeft--;

            Debug.Log(bulletSpawnLocation);
            GameObject currentBullet = Instantiate(bullet, bulletSpawnLocation.transform.position, Quaternion.identity);
            currentBullet.transform.forward = directionToFire.normalized;
            if (whoFired.gameObject.tag == "PlayerOne")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 1;
            }
            else if (whoFired.gameObject.tag == "PlayerTwo")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 2;
            }
            currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;

            Invoke("ResetShot", timeBetweenShots);

        }
        else if (bulletsLeft == 0)
        {
            Invoke("Reload", reloadTime);
        }
    }
}
