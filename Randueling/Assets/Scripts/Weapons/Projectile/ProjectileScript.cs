using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int whoOwnsThis;
    public float bulletSpeed;
    Transform opposingTransform;

    public LayerMask whatCanRicochet;
    
    // Start is called before the first frame update
    void Start()
    {
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
         
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "PlayerOne" || collision.gameObject.tag == "PlayerTwo")
        {
            Debug.Log("Hit" + collision.gameObject.tag);
        }

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
}
