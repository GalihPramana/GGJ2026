using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy Prefabs")]
    public GameObject[] enemyPrefabs; // merah, biru, kuning

    [Header("Spawn Points")]
    public Transform[] spawnPoints; // point 1,2,3

    [Header("Spawn Settings")]
    public float spawnInterval = 10f;

    private float spawnTimer;
    public int enemiesOnScreen = 0;
    private int enemiesLeftToSpawn = 5;

    private EnemyCounter waveCounter;

    public void AddCounter(int addition)
    {
        enemiesOnScreen += addition;
    }
    private void Start()
    {
        waveCounter = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();
    }
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            Debug.Log(enemiesLeftToSpawn + " " + enemiesOnScreen);
            if (enemiesOnScreen < 5 && enemiesLeftToSpawn > 0)
            {
                enemiesLeftToSpawn--;
                enemiesOnScreen++;
                spawnTimer = spawnInterval;
                SpawnEnemy();
            }
            if (enemiesOnScreen <= 0 && enemiesLeftToSpawn <= 0)
            {
                enemiesLeftToSpawn = 5;
                waveCounter.AddCounter(1);
            }
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
