using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float SpawnRate = 10f;
    public float xRange = 120.0f;
    public float yRange = 120.0f;
    public float zRange = 60.0f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", SpawnRate, SpawnRate);
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), Random.Range(1, zRange));
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}