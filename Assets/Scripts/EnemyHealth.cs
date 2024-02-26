using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public Score scoreScript;

    void Start()
    {
        scoreScript = GameObject.FindWithTag("score").GetComponent<Score>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Change 150 to a variable once thier are other enemies
        scoreScript.score += 150;
        Destroy(gameObject);
    }
}