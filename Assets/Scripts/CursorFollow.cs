using UnityEngine;
using UnityEngine.UI;

public class CursorFollow : MonoBehaviour
{
    RectTransform rect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        Cursor.visible = false;
    }

    void Update()
    {
        rect.position = Input.mousePosition;
    }
}
