using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClueKeyDetect : MonoBehaviour
{
    [SerializeField] private string targetClueName;
    [SerializeField] private ScoreBoard scoreboard;

    private void OnTriggerEnter(Collider other)
    {
        string otherName = other.gameObject.name;
        if (string.Equals(otherName, targetClueName))
        {
            collisionCallBack();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void collisionCallBack()
    {
        scoreboard.notifyKeyUnlock();
    }
}
