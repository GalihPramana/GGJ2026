using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject redPlayerPrefab;
    public GameObject bluePlayerPrefab;
    public GameObject greenPlayerPrefab;

    GameObject currentPlayer;
    MaskType currentMask = MaskType.Red;

    void Start()
    {
        SpawnPlayer(currentMask);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeMask(MaskType.Red);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeMask(MaskType.Blue);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeMask(MaskType.Green);
    }

    void ChangeMask(MaskType newMask)
    {
        if (newMask == currentMask)
            return;

        Vector3 pos = currentPlayer.transform.position;

        Destroy(currentPlayer);
        currentMask = newMask;
        SpawnPlayer(newMask, pos);
    }

    void SpawnPlayer(MaskType mask, Vector3? spawnPos = null)
    {
        GameObject prefab = GetPrefab(mask);
        Vector3 pos = spawnPos ?? Vector3.zero;

        currentPlayer = Instantiate(prefab, pos, Quaternion.identity);
    }

    GameObject GetPrefab(MaskType mask)
    {
        switch (mask)
        {
            case MaskType.Red: return redPlayerPrefab;
            case MaskType.Blue: return bluePlayerPrefab;
            case MaskType.Green: return greenPlayerPrefab;
        }
        return redPlayerPrefab;
    }
}
