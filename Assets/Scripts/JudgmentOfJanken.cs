using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgmentOfJanken : SingletonMonoBehaviour<JudgmentOfJanken>
{
    [SerializeField] string winText;
    [SerializeField] string drawText;
    [SerializeField] string loseText;
    public void JankenJudge()
    {
        string myHand = GameObject.FindGameObjectWithTag("Player").GetComponent<MyHand>().myHand;
        string enemyHand = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>().enemyResult;
        Text resuleText = GetComponent<Text>();
        if (enemyHand == "グー")
        {
            if (myHand == "グー")
            {
                resuleText.text = drawText;
                RecordWar.Instance.draw++;
            }
            else if (myHand == "チョキ")
            {
                resuleText.text = loseText;
                RecordWar.Instance.lose++;
            }
            else
            {
                resuleText.text = winText;
                RecordWar.Instance.win++;
            }
        }
        else if (enemyHand == "チョキ")
        {
            if (myHand == "グー")
            {
                resuleText.text = winText;
                RecordWar.Instance.win++;
            }
            else if (myHand == "チョキ")
            {
                resuleText.text = drawText;
                RecordWar.Instance.draw++;
            }
            else
            {
                resuleText.text = loseText;
                RecordWar.Instance.lose++;
            }
        }
        else
        {
            if (myHand == "グー")
            {
                resuleText.text = loseText;
                RecordWar.Instance.lose++;
            }
            else if (myHand == "チョキ")
            {
                resuleText.text = winText;
                RecordWar.Instance.win++;
            }
            else
            {
                resuleText.text = drawText;
                RecordWar.Instance.draw++;
            }
        }
    }

    public void TellResult()
    {
        
        
    }
}
