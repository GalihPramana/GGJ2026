using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public float attackDamagePerSecond = 10f;

    private Transform towerTarget;
    private TowerHealth towerHealth;
    private bool isAttacking = false;

    private EnemyCounter waveCounter;
    void Start()
    {
        waveCounter = GameObject.Find("EnemyCounter").GetComponent<EnemyCounter>();

        GameObject tower = GameObject.FindGameObjectWithTag("Tower");

        speed = 3f + (waveCounter.GetCounter() * 0.5f);

        if (tower != null)
        {
            towerTarget = tower.transform;
            towerHealth = tower.GetComponent<TowerHealth>();
        }
    }

    void Update()
    {
        if (towerTarget == null) return;

        if (!isAttacking)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                towerTarget.position,
                speed * Time.deltaTime
            );
        }

        if (isAttacking && towerHealth != null)
        {
            towerHealth.TakeDamagePerSecond(attackDamagePerSecond);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tower"))
        {
            isAttacking = true;
            Debug.Log("Enemy mulai menyerang Tower");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Tower"))
        {
            isAttacking = false;
            Debug.Log("Enemy berhenti menyerang Tower");
        }
    }
}
