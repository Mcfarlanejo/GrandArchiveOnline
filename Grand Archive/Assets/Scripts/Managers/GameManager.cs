using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }
    static GameManager _instance;

    private void Awake()
    {
        _instance = this;
    }
    #endregion
    public TMPro.TMP_Text nextTurnText;
    public TMPro.TMP_Text playerIndicator;

    public CardManager player1;
    public CardManager player2;
    public CardManager currentPlayer;

    public List<Card> stack;
    public int turnCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        BeginGame();
    }

    private void BeginGame()
    {
        System.Random rnd = new System.Random();
        
        if (rnd.Next(2) == 0)
        {
            currentPlayer = player1;
            playerIndicator.text = "Player 1";
            player2.phase = Phase.Draw;
            player1.Materialize();
        }
        else
        {
            currentPlayer = player2;
            playerIndicator.text = "Player 2";
            player1.phase = Phase.Draw;
            player2.Materialize();

        }
        turnCount++;
    }

    public void NextPhase()
    {        
        if (currentPlayer.phase == Phase.End)
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
                playerIndicator.text = "Player 2";
            }
            else
            {
                currentPlayer = player1;
                playerIndicator.text = "Player 1";
            }
            turnCount++;
            if (currentPlayer.firstTurn)
            {
                currentPlayer.Materialize();
            }
            if (turnCount > 2)
            {
                currentPlayer.phase = Phase.WakeUp;
            }
        }
        else
        {
            currentPlayer.phase++;
        }
        
        if (currentPlayer.phase == Phase.End)
        {
            nextTurnText.text = "Next Turn";
        }
        else
        {
            nextTurnText.text = "Next Phase";
        }

        currentPlayer.RunCurrentPhase();

        Debug.Log($"Player: {currentPlayer.name}; Phase: {currentPlayer.phase}; Turn: {turnCount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResolveStack()
    {
        for (int i = stack.Count; i > 0; i--)
        {
            ResolveCard(stack[i]);
        }
    }

    void ResolveCard(Card card)
    {
        foreach (CardEffect effect in card.effects)
        {
            if (effect.triggerType == TriggerType.OnCast)
            {
                //effect.effect.ApplyEffect()
            }
        }
    }
}
