using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    string[] enemyJankenList = { "グー", "チョキ", "パー" };
    public string enemyResult = "";

    // Update is called once per frame
    void Update()
    {
        if (StateManager.Instance.gameState == StateManager.GameState.PrePlay)
        {
            int index = Random.Range(0, 3);
            enemyResult = enemyJankenList[index];
            Debug.Log("敵の手は:" + enemyResult);

        }
    }
}
