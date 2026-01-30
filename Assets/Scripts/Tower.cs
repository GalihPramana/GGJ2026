using UnityEngine;

public class Tower : MonoBehaviour
{
    public float hp = 100f;

    public void TakeDamage(float dmg)
    {
        hp -= dmg;

        if (hp <= 0)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(other.gameObject);
        }
    }
}
