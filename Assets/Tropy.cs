using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Trophy : MonoBehaviour
{
    [SerializeField] private string collisionTag = "PlayerCollision";
    [SerializeField] private ScoreBoard scoreboard;
    [SerializeField] private string winScene = "Scenes/Win";

    private void OnTriggerEnter(Collider other)
    {

        if (!other.CompareTag(collisionTag)) return;

        collisionCallBack();

        Destroy(gameObject);
    }

    private void collisionCallBack()
    {
        if (!scoreboard) return;
        if (!scoreboard.getWinState()) return;
        SceneManager.LoadScene(winScene);
    }
}
