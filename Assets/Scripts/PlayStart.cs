using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayStart : MonoBehaviour
{
    public void Play()
    {
        StateManager.Instance.gameState = StateManager.GameState.PrePlay;
        gameObject.GetComponent<Button>().interactable = false;
    }
}
