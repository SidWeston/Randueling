using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChanger : MonoBehaviour
{
    public Mesh[] meshes;
    int meshNumber = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            if (meshNumber == 0)
            {
                GetComponent<MeshFilter>().mesh = meshes[0];
                GetComponent<MeshCollider>().sharedMesh = meshes[0];
                meshNumber += 1;
            }
            else if (meshNumber == 1)
            {
                GetComponent<MeshFilter>().mesh = meshes[1];
                GetComponent<MeshCollider>().sharedMesh = meshes[1];
                meshNumber += 1;
            }
            else if (meshNumber == 2)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
