using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

/*     //[SerializeField] private float spawnRate=1f; // tiempo que tarda en spawnear, innecesario?
    [SerializeField] private GameObject[] enemyPrefabs; // array permite spawnear diferentes prefabs
    [SerializeField] private bool canSpawn=true;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        if(canSpawn==true){
            int rand=Random.Range(0,enemyPrefabs.Length);
            GameObject enemyToSpawn=enemyPrefabs[rand];
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            if(enemyToSpawn.Find("EnemyRed(Clone)")||enemyToSpawn.Find("EnemyWhite(Clone)")){
                canSpawn=false;
            }else{
                canSpawn=true;
            }
        }
        /* WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while(true){
            yield return wait;
            int rand=Random.Range(0,enemyPrefabs.Length);
            GameObject enemyToSpawn=enemyPrefabs[rand];
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    } */
}
