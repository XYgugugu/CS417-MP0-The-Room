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

    public void incrementScore()
    {
        score++;
        renderScoreBoard();
    }

    public void decreaseScore()
    {
        score--;
        renderScoreBoard();
    }
}
