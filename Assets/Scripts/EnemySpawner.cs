using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        GameObject e = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        Enemy enemy = e.GetComponent<Enemy>();

        enemy.maskType = (MaskType)Random.Range(0, 3);
    }
}
