using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public float damage = 10f;
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("EnemyRed") &&
            !other.CompareTag("EnemyBlue") &&
            !other.CompareTag("EnemyGreen"))
            return;

        if (IsEffective(other.tag))
        {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
        else
        {
            //Debug.Log("? Salah elemen, tidak ada damage");
        }

        Destroy(gameObject);
    }

    bool IsEffective(string enemyTag)
    {
        // Hijau -> Merah
        if (CompareTag("ProjectileGreen") && enemyTag == "EnemyBlue")
            return true;

        // Merah -> Biru
        if (CompareTag("ProjectileRed") && enemyTag == "EnemyGreen")
            return true;

        // Biru -> Hijau
        if (CompareTag("ProjectileBlue") && enemyTag == "EnemyRed")
            return true;

        return false;
    }
}
