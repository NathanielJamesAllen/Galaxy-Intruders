using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    // Array of waypoints to walk from one to the next one
    private Waypoints waypoints;

    public GameObject explosionPrefab;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

	// Use this for initialization
	private void Start () {

        // Set position of Enemy as position of the first waypoint
        waypoints = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Waypoints>();
        


	}
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
	
	// Update is called once per frame
	private void Update () {

        // Move Enemy
        Move();
	}

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.points.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints.points[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints.points[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
