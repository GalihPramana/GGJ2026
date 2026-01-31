using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    void Update()
    {
        FlipToMouse();
    }

    void FlipToMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePos.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f); // hadap kiri
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f); // hadap kanan
        }
    }
}