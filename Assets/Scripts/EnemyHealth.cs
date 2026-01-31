using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 50f;
    public float currentHealth;
    private ScoreManager scoreManager;
    private EnemySpawner spawner;

    void Start()
    {
        currentHealth = maxHealth;
        scoreManager = GameObject.Find("ScoreCounter").GetComponent<ScoreManager>();
        spawner = GameObject.Find("SpawnEnemy").GetComponent<EnemySpawner>();

        if (scoreManager == null)
            Debug.LogError("ScoreManager TIDAK DITEMUKAN DI SCENE!");
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        spawner.AddCounter(-1);
        scoreManager.AddCounter(10);
        //Debug.Log("? Enemy Mati");
        Destroy(gameObject);
    }
}
