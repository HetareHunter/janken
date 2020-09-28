using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyHand : MonoBehaviour
{
    public string myHand = "";
    public void Rock()
    {
        myHand = "グー";
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
    public void Scissor()
    {
        myHand = "チョキ";
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
    public void Paper()
    {
        myHand = "パー";
        JudgmentOfJanken.Instance.JankenJudge();
        StateManager.Instance.gameState = StateManager.GameState.PlayEnd;
    }
}
