using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
 
    public void AddScore(int amount)
    {
        score += amount;
        UpdateText();
    }

    void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }
}
