using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShotgun : WeaponBase
{
    //how many pellets are fired per shot
    public int bulletsPerFire;

    public override void FireWeapon(Vector3 directionToFire)
    {

        if (isProjectile && readyToShoot && bulletsLeft > 0)
        {
            pickupScript.RotReact(recoil);

            readyToShoot = false;
            bulletsLeft--;

            for(int i = 1; i <= bulletsPerFire; i++)
            {
                GameObject currentBullet = Instantiate(bullet, bulletSpawnLocation.transform.position, Quaternion.identity);
                float spreadAmountX = Random.Range(-spread, spread);
                float spreadAmountY = Random.Range(-spread/2, spread/2);
                currentBullet.transform.forward = directionToFire.normalized;
                currentBullet.transform.forward += new Vector3(spreadAmountX, spreadAmountY, 0);
                //Temp variable to decide bullet owner, change this later!
                GameObject whoFired = transform.parent.gameObject;
                if (whoFired.gameObject.tag == "PlayerOne")
                {
                    currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 1;
                    currentBullet.GetComponent<ProjectileScript>().whoShot = whoFired;
                    currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
                }
                else if (whoFired.gameObject.tag == "PlayerTwo")
                {
                    currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 2;
                    currentBullet.GetComponent<ProjectileScript>().whoShot = whoFired;
                    currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
                }

            }
            Invoke("ResetShot", timeBetweenShots);

        }
        else if (bulletsLeft == 0 && !reloading)
        {
            reloading = true;
            pickupScript.Reload();
            Invoke("Reload", reloadTime);
        }
        else
        {
            //TODO: Implement Raycasts
        }

    }

}
