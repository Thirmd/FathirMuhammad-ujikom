using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float[] animalSpeeds;
    public float spawnInterval = 2f;
    public float spawnRange = 5f;
    public Transform player;
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies(){
        while(true){
            int animalia = Random.Range(0, animalPrefabs.Length);
            GameObject animal = Instantiate(animalPrefabs[animalia], GetSpawnPosition(), Quaternion.identity);

            float speed = animalSpeeds[animalia];

            AnimalMovement animalMovement = animal.GetComponent<AnimalMovement>();
            if(animalMovement != null){
                animalMovement.SetSpeed(speed);
                animalMovement.SetDirection(Vector2.left);
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    Vector3 GetSpawnPosition(){
        return new Vector3(3f,3f, Random.Range(-spawnRange,spawnRange));
    }
}
