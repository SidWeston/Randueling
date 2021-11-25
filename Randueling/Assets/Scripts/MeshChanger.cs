using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChanger : MonoBehaviour
{
    public Mesh[] meshes;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            if (GetComponent<MeshFilter>().mesh = meshes[0])
            {
                if (GetComponent<MeshFilter>().mesh = meshes[0])
                {
                    GetComponent<MeshFilter>().mesh = meshes[1];
                }
            }
            if (GetComponent<MeshFilter>().mesh = meshes[1])
            {
                if (GetComponent<MeshFilter>().mesh = meshes[1])
                {
                    GetComponent<MeshFilter>().mesh = meshes[2];
                }
            }
            if (GetComponent<MeshFilter>().mesh = meshes[2])
{
                if (GetComponent<MeshFilter>().mesh = meshes[2])
                {
                    GetComponent<MeshFilter>().mesh = meshes[3];
                }
            }
        }
    }
}