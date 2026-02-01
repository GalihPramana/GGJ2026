using UnityEngine;

public class TitleFLoat : MonoBehaviour
{
    public float speed = 2f;
    public float height = 10f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * speed) * height;
        transform.localPosition = startPos + new Vector3(0, y, 0);
    }
}