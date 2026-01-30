using UnityEngine;

public class Enemy : MonoBehaviour
{
    public MaskType maskType;
    public float hp = 10f;
    public float speed = 2f;
    Transform tower;

    void Start()
    {
        tower = GameObject.FindWithTag("Tower").transform;
    }

    void Update()
    {
        MoveToTower();
    }

    void MoveToTower()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            tower.position,
            speed * Time.deltaTime
        );
    }

    public void TakeDamage(float dmg, MaskType playerMask)
    {
        if (!CounterSystem.IsCounter(playerMask, maskType))
            return; // kebal

        hp -= dmg;

        if (hp <= 0)
            Destroy(gameObject);
    }
}
