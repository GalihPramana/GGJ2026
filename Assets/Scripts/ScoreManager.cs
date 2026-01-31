using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;
    public void AddCounter(float addition)
    {
        score += addition;
        Debug.Log(score);
    }
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "" + score;
    }
    // Update is called once per frame
}
