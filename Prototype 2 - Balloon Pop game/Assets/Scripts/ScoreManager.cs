using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score; // Keep track of he score
    public TextMeshProUGUI scoreText; // Reference Text UI Object to display and update
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    public void IncreaseScoreText(int amount)
    {
        Score += amount; // Increase score by amount
        UpdateScoreText(); // Update score UI text
    }
    public void DecraseScoreText(int amount)
    {
        Score -= amount; // Increase score by amount
        UpdateScoreText(); // Update score UI text
    }
    public void UpdateScoreText
    {
        scoreText.text = "Score:" + score;
    }
}
