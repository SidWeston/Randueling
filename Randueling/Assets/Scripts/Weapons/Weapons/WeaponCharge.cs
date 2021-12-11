using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCharge : WeaponBase
{
    public float fireInterval; //the interval in which the bullets are unloaded from the weapon after charging
    public float chargeTime; //how long the gun takes to charge when the fire button is pressed

    public int bulletsPerFire; //the number of bullets the weapon will fire after charging
    private Vector3 fireDirection;
    public bool hasFired = false;

    private void FireShots()
    {

        if (!hasFired)
        {
            hasFired = true;
            for(int i = 1; i <= bulletsPerFire; i++)
            {
                Invoke("FireShots", i * fireInterval);
                if(i == bulletsPerFire)
                {
                    Invoke("ResetShot", reloadTime);
                    Invoke("Reload", reloadTime);
                }
            }
        }
        else if(hasFired)
        {
            pickupScript.RotReact(recoil);
            bulletsLeft--;

            GameObject currentBullet = Instantiate(bullet, bulletSpawnLocation.transform.position, Quaternion.identity);
            float spreadAmount = Random.Range(-spread, spread);
            currentBullet.transform.forward = fireDirection.normalized;
            currentBullet.transform.forward += new Vector3(spreadAmount, 0, 0);

            GameObject whoFired = transform.parent.gameObject;
            if (whoFired.gameObject.tag == "PlayerOne")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 1;
                currentBullet.GetComponent<ProjectileScript>().whoShot = this.transform.parent.gameObject;
                currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
            }
            else if (whoFired.gameObject.tag == "PlayerTwo")
            {
                currentBullet.GetComponent<ProjectileScript>().whoOwnsThis = 2;
                currentBullet.GetComponent<ProjectileScript>().whoShot = this.transform.parent.gameObject;
                currentBullet.GetComponent<ProjectileScript>().bulletSpeed = bulletVelocity;
            }
        }
    }

    public override void FireWeapon(Vector3 directionToFire)
    {

        fireDirection = directionToFire;

        if (isProjectile && readyToShoot && bulletsLeft > 0)
        {
            Invoke("FireShots", chargeTime);
            readyToShoot = false;
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

    public override void ResetShot()
    {
        base.ResetShot();

        hasFired = false;
    }


}
