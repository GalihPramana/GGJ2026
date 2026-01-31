using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy Prefabs")]
    public GameObject[] enemyPrefabs; // merah, biru, kuning

    [Header("Spawn Points")]
    public Transform[] spawnPoints; // point 1,2,3

    [Header("Spawn Settings")]
    public float spawnInterval = 2f;

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    void SpawnEnemy()
    {
        if (enemyPrefabs.Length == 0 || spawnPoints.Length == 0)
            return;

        // random enemy
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        // random spawn point
        int spawnIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(
            enemyPrefabs[enemyIndex],
            spawnPoints[spawnIndex].position,
            Quaternion.identity
        );
    }
}
