using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunWeapon : WeaponBase
{

    public int bulletsPerShot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void FireWeapon(Vector3 directionToFire, GameObject whoFired)
    {

        for(int i = 0; i < bulletsPerShot; ++i)
        {

            //TODO: Implement spread on the pellets so all shotgun bullets dont fire in a straight line

            if (isProjectile && readyToShoot && bulletsLeft > 0)
            {

                readyToShoot = false;
                bulletsLeft--;

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
}
