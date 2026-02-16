using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int value = 1;
    [SerializeField] private string collisionTag = "PlayerCollision";
    [SerializeField] private ScoreBoard scoreboard;

    private void OnTriggerEnter(Collider other)
    {

        if (!other.CompareTag(collisionTag)) return;

        collisionCallBack();

        Destroy(gameObject);
    }

    private void collisionCallBack()
    {
        if (!scoreboard) return;
        scoreboard.incrementScore(value);
    }
}
