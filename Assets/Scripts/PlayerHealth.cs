using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public int enemyCollisionDamage = 40;
    public Text healthText;
    public PostProcessVolume postProcessVolume;
    public Vignette vignetteEffect;

    void Start()
    {
        currentHealth = maxHealth;
        postProcessVolume.profile.TryGetSettings(out vignetteEffect);
    }

    private void Update()
    {
        healthText.text = "Health: " + currentHealth;
        float damagePercentage = 1f - currentHealth / maxHealth;
        if(damagePercentage < .8f)
        {
            vignetteEffect.intensity.value = damagePercentage;
        }
        else
        {
            vignetteEffect.intensity.value = .8f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(enemyCollisionDamage);
            Debug.Log("Took" + enemyCollisionDamage + " Damage");
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Died");
    }
}