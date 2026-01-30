using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;

    public GameObject fireProjectile;
    public GameObject iceProjectile;
    public GameObject poisonProjectile;

    MaskManager maskManager;

    void Awake()
    {
        maskManager = GetComponent<MaskManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        GameObject projectile = null;

        switch (maskManager.currentMask)
        {
            case MaskType.Red:
                projectile = fireProjectile;
                break;

            case MaskType.Blue:
                projectile = iceProjectile;
                break;

            case MaskType.Green:
                projectile = poisonProjectile;
                break;
        }

        if (projectile != null)
            Instantiate(projectile, firePoint.position, firePoint.rotation);
    }
}
