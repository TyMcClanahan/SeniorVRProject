using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3.0f;

    void Update()
    {
        player = GameObject.FindWithTag("Player").transform;

        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}