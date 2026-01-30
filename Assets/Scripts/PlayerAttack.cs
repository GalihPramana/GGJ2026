using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;

    public GameObject fireProjectile;
    public GameObject iceProjectile;
    public GameObject poisonProjectile;

    MaskManager maskManager;
    Camera cam;

    void Awake()
    {
        maskManager = GetComponent<MaskManager>();
        cam = Camera.main;
    }

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        AimToMouse();

        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void AimToMouse()
    {
        Vector3 mouseWorldPos =
            cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        Vector3 dir = mouseWorldPos - transform.position;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        firePoint.rotation = Quaternion.Euler(0, 0, angle);
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
