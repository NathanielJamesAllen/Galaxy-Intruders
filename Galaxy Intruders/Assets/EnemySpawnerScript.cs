using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject Enemy;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    int spawnAmount = 0;
    int i = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time > i){
            i += 3;
        
            if (spawnAmount <= 9){

                
                whereToSpawn = new Vector2 (-18.0f, 8.5f);
                Instantiate (Enemy, whereToSpawn, Quaternion.identity);
                spawnAmount = spawnAmount + 1;
                Debug.Log("whatevs");
            }
        }
    }
}
