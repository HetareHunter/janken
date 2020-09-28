using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHand : MonoBehaviour
{
    GameObject enemy;
    Text enemyText;
    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyText = gameObject.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if (StateManager.Instance.gameState == StateManager.GameState.PlayEnd)
        {
            enemyText.text = "相手は：" + enemy.GetComponent<Enemy>().enemyResult;
        }
    }
}
