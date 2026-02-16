using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text scoreboard;
    private int score = 0;
    void Start()
    {
        score = 0;
    }

    private void renderScoreBoard()
    {
        scoreboard.text = $"Score: {score}";
    }

    public void incrementScore(int d_score)
    {
        score += d_score;
        renderScoreBoard();
    }

    public void decreaseScore(int d_score)
    {
        score = Mathf.Max(0, score - d_score);
        renderScoreBoard();
    }

    public void reset()
    {
        score = 0;
        renderScoreBoard();
    }
}
