using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public MaskType currentMask;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetMask(MaskType.Red);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            SetMask(MaskType.Blue);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            SetMask(MaskType.Green);
    }

    void SetMask(MaskType newMask)
    {
        currentMask = newMask;
        Debug.Log("Current Mask: " + currentMask);
    }
}
