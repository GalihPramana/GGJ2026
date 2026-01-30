using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public MaskManager maskManager;

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
            Debug.Log("Attack with " + maskManager.currentMask);
            // nanti spawn projectile di sini
        }
    }
}
