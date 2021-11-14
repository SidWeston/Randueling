using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnObject : MonoBehaviour
{

    public List<GameObject> prefabs = new List<GameObject>();

    public Vector3 center;
    public Vector3 size;

    public float shouldSpawn;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObj();
        SpawnObj();
        SpawnObj();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn > 0)
            SpawnObj();


    }

    // Spawns objects at random into the designed cube in random order
    public void SpawnObj() {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), (Random.Range(-size.y / 2, size.y / 2)), (Random.Range(-size.z / 2, size.z / 2)));

        int randomprefab = Random.Range(0, prefabs.Count);
        Instantiate(prefabs[randomprefab], pos, prefabs[randomprefab].transform.rotation);
    }

    // Creates red cube on screen to show area in which prefabs can spawn
    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }


    public void OnSpawn(InputAction.CallbackContext context)
    {
        shouldSpawn = context.ReadValue<float>();
    }

}
