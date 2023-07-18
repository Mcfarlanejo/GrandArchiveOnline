using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Phase { WakeUp, Materialize, Recollection, Draw, Main, End }
public class CardManager : MonoBehaviour
{
    public PlayerDeck deck;
    private List<Card> mainDeck = new List<Card>();
    private List<Card> materialDeck = new List<Card>();
    private List<Card> sideboard = new List<Card>();

    public List<Card> hand = new List<Card>();
    public List<Card> memory = new List<Card>();
    public List<Card> field = new List<Card>();
    public List<Card> graveyard = new List<Card>();
    public List<Card> banishment = new List<Card>();

    public int damageCounters = 0;
    public int lifeTotal;
    public int level;
    public int levelCounters;
    public int enlightenCounters = 0;
    public int preperationCounters = 0;

    public Phase phase = Phase.Main;

    private void Awake()
    {
        mainDeck.Equals(deck.mainDeck);
        materialDeck.Equals(deck.materialDeck);
        sideboard.Equals(deck.sideboard);
    }

    public void RunCurrentPhase()
    {
        switch (phase)
        {
            case Phase.WakeUp:
                WakeUp();
                break;
            case Phase.Materialize:
                Materialize();
                break;
            case Phase.Recollection:
                Recollection();
                break;
            case Phase.Draw:
                Draw();
                break;
            case Phase.Main:
                MainPhase();
                break;
            case Phase.End:
                End();
                break;
            default:
                break;
        }
    }

    private void WakeUp()
    {
        foreach (Card card in field)
        {
            card.rested = false;
        }
    }

    private void Materialize()
    {
        throw new NotImplementedException();
    }

    private void Recollection()
    {
        foreach (Card card in memory)
        {
            hand.Add(card);
        }
    }

    private void Draw()
    {
        DrawCard();
    }

    private void MainPhase()
    {
        throw new NotImplementedException();
    }

    private void End()
    {
        
    }
    
    public void Damage(int amount)
    {
        damageCounters += amount;
    }

    public void DrawCard()
    {
        hand.Add(mainDeck[mainDeck.Count]);
    }

    public void Glimpse(int amount)
    {
        //Do glimpse things
    }

    public void UseEnlighten()
    {
        if (enlightenCounters >= 3)
        {
            enlightenCounters -= 3;
            DrawCard();
        }
    }
}
