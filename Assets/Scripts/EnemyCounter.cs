using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public float counter;
    public TextMeshProUGUI scoreText;
    public void AddCounter(float addition)
    {
        counter += addition;
        Debug.Log(counter);
    }

    public float GetCounter()
    {
        return counter;
    }
    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        scoreText.text = "" + counter;
    }
    // Update is called once per frame
}
