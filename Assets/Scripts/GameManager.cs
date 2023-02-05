using QuantumTek.QuantumDialogue;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private readonly GameObject Player;
    public QD_DialogueHandler CurrentDialogue { get; private set; }
    public GameObject DialogueCanvas;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public PlayerData getPlayerInfo()
    {
        PlayerData mock = new PlayerData();
        mock.CreatureName = "Formiga";
        return mock;
    }

    public void startNewDialogue(GameObject caller)
    {
        Debug.Log(caller);
        CurrentDialogue = caller.GetComponent<QD_DialogueHandler>();
        DialogueCanvas.GetComponent<QD_Dialogue_Canvas>().UpdateDialogueHandler(CurrentDialogue);
    }
}
