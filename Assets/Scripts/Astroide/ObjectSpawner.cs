using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectSpawner : MonoBehaviour
{
   
    public GameObject cubePrefab;
    public GameObject rij;
    public GameObject defence;
    public int check;
    public float spawnThreshold = 1f;

    private float spawnTimer = 0;

 
    
    public bool muur = false;
   
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

         check = Random.Range(0, 100);

        if (check <= 21 && muur == false)
        {
            muur = true;
            Vector3 spawnPositionWall = new Vector3(Random.Range(-14, 0), Random.Range(-10, 10), 0);
            Instantiate(defence, spawnPositionWall, Quaternion.identity);
            spawnTimer = 0;
            StartCoroutine(Example());
        }
        else
        {
            Vector3 spawnPosition = new Vector3(15, 12, 0);
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
            spawnTimer = 0;
        }
        if(check >= 11 && check <= 20 && muur == false)
        {
            Vector3 spawnPositionRij1 = new Vector3(20, 10, 0);
            Instantiate(rij, spawnPositionRij1, Quaternion.identity);
            Vector3 spawnPositionRij2 = new Vector3(20, 0, 0);
            Instantiate(rij, spawnPositionRij2, Quaternion.identity);
            Vector3 spawnPositionRij3 = new Vector3(20, -10, 0);
            Instantiate(rij, spawnPositionRij3, Quaternion.identity);
            spawnTimer = 0;
        }



    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(3);
        spawnThreshold = 0;
        yield return new WaitForSeconds(2);
        
        spawnThreshold = 1;
        yield return new WaitForSeconds(3);
        Destroy(GameObject.Find("Defence(Clone)"));
        muur = false;
    }

}