using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
   

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(moveSpeed * moveAmount * -1,0,0);
        
    }
}
