using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    [Header("Mask Info")]
    public MaskType maskType; // SET DI PREFAB

    void Update()
    {
        Move();
        Attack();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Attack with " + maskType);
            // nanti spawn projectile sesuai maskType
        }
    }
}
