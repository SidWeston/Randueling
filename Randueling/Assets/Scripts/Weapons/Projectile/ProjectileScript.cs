using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int whoOwnsThis;
    public float bulletSpeed;
    Transform opposingTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(whoOwnsThis == 1)
        {
            opposingTransform = GameObject.FindGameObjectWithTag("Player2").transform;
        }
        else
        {
            opposingTransform = GameObject.FindGameObjectWithTag("Player1").transform;
        }
        transform.forward = opposingTransform.position - transform.position;
    }
}
