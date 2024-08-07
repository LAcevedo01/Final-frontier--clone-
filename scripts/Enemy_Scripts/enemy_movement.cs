using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    public float moveSpeed = 2f; // speed of the enemy's movement
    public float leftBound = -10f; // left boundary of the enemy's movement
    public float rightBound = 10f; // right boundary of the enemy's movement
    public float floatSpeed = 0.5f; // speed of the enemy's float
    public float floatAmplitude = 0.5f; // amplitude of the enemy's float

    private GameObject player;
    private float startY; // starting Y position of the enemy

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startY = transform.position.y; // save the starting Y position of the enemy
    }

    void Update()
    {
        // check if player is to the left of the enemy
        if (player.transform.position.x < transform.position.x && transform.position.x > leftBound)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        // check if player is to the right of the enemy
        else if (player.transform.position.x > transform.position.x && transform.position.x < rightBound)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        // if player is within the boundaries, but enemy is already moving in one direction, keep moving in that direction
        else if (transform.position.x <= leftBound)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else if (transform.position.x >= rightBound)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        
        // float up and down
        float newY = startY + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector2(transform.position.x, newY);
    }
}
