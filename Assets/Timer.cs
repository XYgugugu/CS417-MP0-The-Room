using UnityEngine;
using TMPro;
using System.Collections;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private int startSeconds = 60;

    [Header("UI")]
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private GameObject loss;

    private int remainingSeconds;
    private Coroutine timerCoroutine;

    void Start()
    {
        remainingSeconds = Mathf.Max(0, startSeconds);
        UpdateTimerText(remainingSeconds);

        // timerCoroutine = StartCoroutine(CountdownRoutine());
    }

    private IEnumerator CountdownRoutine()
    {
        while (remainingSeconds > 0)
        {
            yield return new WaitForSeconds(1f);
            remainingSeconds--;
            UpdateTimerText(remainingSeconds);
        }

        UpdateTimerText(0);

        if (loss != null)
        {
            loss.SetActive(true);
        }
    }

    private void UpdateTimerText(int seconds)
    {
        int m = seconds / 60;
        int s = seconds % 60;
        timerText.text = $"{m:00}:{s:00}";
    }

    // Optional controls
    public void StopTimer()
    {
        if (timerCoroutine != null) StopCoroutine(timerCoroutine);
        timerCoroutine = null;
    }

    public void RestartTimer()
    {
        StopTimer();
        remainingSeconds = Mathf.Max(5, startSeconds);
        UpdateTimerText(remainingSeconds);
        timerCoroutine = StartCoroutine(CountdownRoutine());
    }
}
