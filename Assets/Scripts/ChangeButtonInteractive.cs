using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonInteractive : MonoBehaviour
{
    [SerializeField] Button[] jankenButtons;
    [SerializeField] Button playButton;
    [SerializeField] Button moveResultButton;

    private void Update()
    {
        switch (StateManager.Instance.gameState)
        {
            case StateManager.GameState.Stanby:
                moveResultButton.interactable = true;
                playButton.interactable = true;
                break;
                
            case StateManager.GameState.PrePlay:
                moveResultButton.interactable = false;
                foreach (var item in jankenButtons)
                {
                    item.interactable = true;
                }
                break;

            case StateManager.GameState.Play:
                break;

            case StateManager.GameState.PlayEnd:
                foreach (var item in jankenButtons)
                {
                    item.interactable = false;
                }
                break;

            default:
                break;
        }
    }
}
