using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    private float damageTimer = 0f;
    private float damageInterval = 1f; // 1 detik

    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Tower HP: " + currentHealth);
    }

    public void TakeDamagePerSecond(float damagePerSecond)
    {
        damageTimer += Time.deltaTime;

        if (damageTimer >= damageInterval)
        {
            damageTimer = 0f;

            currentHealth -= damagePerSecond;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

            Debug.Log("Tower HP: " + currentHealth);

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Debug.Log("?? Tower Hancur!");
        Destroy(gameObject);
    }
}
