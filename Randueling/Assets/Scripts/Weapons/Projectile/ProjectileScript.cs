using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int whoOwnsThis;
    public float bulletSpeed;
    Transform opposingTransform;

    public LayerMask whatCanRicochet;

    public GameObject whoShot; //reference to the gameobject of the player that fired the bullet
    private WeaponBase weaponScriptRef; // reference to the actual weapon script of the gun that fired the bullet

    [SerializeField]
    private float bulletLifetime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, bulletLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        //if(Physics.Raycast(transform.position, transform.forward, out bulletRay))
        //{
        //    Debug.Log("Hit Something");
        //    reflectedTransform = Vector3.Reflect(transform.forward, bulletRay.point);
        //}
         
        if(!weaponScriptRef)
        {
            weaponScriptRef = whoShot.GetComponentInChildren<WeaponBase>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "PlayerOne" || collision.gameObject.tag == "PlayerTwo")
        {
            Debug.Log("Hit" + collision.gameObject.tag);
        }


        if(weaponScriptRef.doesRichochet)
        {
            Vector3 reflectNormal = collision.contacts[0].normal;
            if (whoOwnsThis == 1)
            {
                opposingTransform = GameObject.FindGameObjectWithTag("PlayerTwo").transform;
            }
            else
            {
                opposingTransform = GameObject.FindGameObjectWithTag("PlayerOne").transform;
            }
            Vector3 reflectedTransform = Vector3.Reflect(transform.forward, reflectNormal);
            Vector3 newDirection = opposingTransform.position - transform.position;
            transform.forward = Vector3.Lerp(newDirection, reflectedTransform, 0.55f);
        }
        else
        {
            Destroy(gameObject); //if the bullet doesnt ricochet, destroy it when it collides with an object
        }
    }
}
