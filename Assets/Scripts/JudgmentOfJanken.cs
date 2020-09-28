using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentOfJanken : SingletonMonoBehaviour<JudgmentOfJanken>
{
    public void JankenJudge()
    {
        string myHand = GameObject.FindGameObjectWithTag("Player").GetComponent<MyHand>().myHand;
        string enemyHand = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>().enemyResult;
        if (enemyHand == "グー")
        {
            if (myHand == "グー")
            {
                RecordWar.Instance.draw++;
            }
            else if (myHand == "チョキ")
            {
                RecordWar.Instance.lose++;
            }
            else
            {
                RecordWar.Instance.win++;
            }
        }
        else if (enemyHand == "チョキ")
        {
            if (myHand == "グー")
            {
                RecordWar.Instance.win++;
            }
            else if (myHand == "チョキ")
            {
                RecordWar.Instance.draw++;
            }
            else
            {
                RecordWar.Instance.lose++;
            }
        }
        else
        {
            if (myHand == "グー")
            {
                RecordWar.Instance.lose++;
            }
            else if (myHand == "チョキ")
            {
                RecordWar.Instance.win++;
            }
            else
            {
                RecordWar.Instance.draw++;
            }
        }
    }
}
