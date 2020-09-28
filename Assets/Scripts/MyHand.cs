using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyHand : MonoBehaviour
{
    public string myHand = "";
    Text myHandText;
    private void Start()
    {
        myHandText = GameObject.Find("MyHandText").GetComponent<Text>();
    }
    public void Rock()
    {
        myHand = "グー";
        myHandText.text = "自分は：" + myHand;
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
    public void Scissor()
    {
        myHand = "チョキ";
        myHandText.text = "自分は：" + myHand;
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
    public void Paper()
    {
        myHand = "パー";
        myHandText.text = "自分は：" + myHand;
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
}
