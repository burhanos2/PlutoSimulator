using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectSpawner2 : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnThreshold = 1f;

    private float spawnTimer = 0;

    // Update is called once per frame
    void Update()
    {

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnThreshold)
        {
            SpawnCube();
        }

    }

    private void SpawnCube()
    {

        Vector3 spawnPosition = new Vector3(10, 12, 0);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        spawnTimer = 0;


    }


}