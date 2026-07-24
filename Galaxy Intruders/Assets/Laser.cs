using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float life = 3;
    public GameObject explosionPrefab;

    void Awake(){
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("Enemy")){
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
                
        }
       
        
        
    }

    void OnBecameInvisible() {
         Destroy(gameObject);
     }
     // Laser removed once off the screen
}
   
