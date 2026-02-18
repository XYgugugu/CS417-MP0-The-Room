using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text scoreboard;
    [SerializeField] private GameObject obsWall;
    private int score = 0;
    private int keysUnlocked = 0;
    private bool winState = false;

    void Start()
    {
        score = 0;
        renderScoreBoard();
    }

    private void renderScoreBoard()
    {
        scoreboard.text = $"Score: {score} | Keys Unlocked: {keysUnlocked}/3";
    }

    public void incrementScore(int d_score)
    {
        score += d_score;
        renderScoreBoard();
        checkAndRemoveWall();
    }

    public void reset()
    {
        score = 0;
        renderScoreBoard();
    }

    public void notifyKeyUnlock()
    {
        keysUnlocked++;
        renderScoreBoard();
        checkAndRemoveWall();
    }

    private void checkAndRemoveWall()
    {
        if (score < 2) return;
        if (keysUnlocked < 3) return;
        winState = true;
        Destroy(obsWall);
    }
    
    public bool getWinState()
    {
        return winState;
    }
}
