using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsPrefabs;
    private float spawnDelay = 2f;
    private float spawnDelaySides = 3f;
    private float timer = 0f;
    private float leftTimer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        leftTimer += Time.deltaTime;
        Spawner();
        LeftSpawner();


    }
    private void Spawner()
    {
        float randomPos = Random.Range(-22, 23);
        
        if (timer > spawnDelay)
        {
            int animalIndex = Random.Range(0, animalsPrefabs.Length);
            Instantiate(animalsPrefabs[animalIndex], new Vector3(randomPos, 0, 32), Quaternion.Euler(0,180,0));
            timer = 0;
        }
    
    }
    private void LeftSpawner()
    {
        float randomZ = Random.Range(-12, 32);
        float randomPos = Random.Range(-22, 23);
        
        if (leftTimer > spawnDelaySides)
        {
            int animalIndex = Random.Range(0, animalsPrefabs.Length);
            Instantiate(animalsPrefabs[animalIndex], new Vector3(-22, 0, randomZ), Quaternion.Euler(0, 90, 0));
            leftTimer = 0;
        }
       
    }
       
}
