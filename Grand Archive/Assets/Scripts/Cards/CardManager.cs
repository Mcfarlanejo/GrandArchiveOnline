using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum Phase { WakeUp, Materialize, Recollection, Draw, Main, End }
public class CardManager : MonoBehaviour
{
    public PlayerDeck deck;
    public List<Card> mainDeck = new List<Card>();

    public List<Card> materialDeck = new List<Card>();
    public List<Card> sideboard = new List<Card>();

    public List<Card> hand = new List<Card>();
    public List<Card> memory = new List<Card>();
    public List<Card> field = new List<Card>();
    public List<Card> lineage = new List<Card>();
    public List<Card> graveyard = new List<Card>();
    public List<Card> banishment = new List<Card>();

    public List<Effect> staticEffects = new List<Effect>();

    public int damageCounters = 0;
    public int lifeTotal;
    public int level;
    public int levelCounters;
    public int enlightenCounters = 0;
    public int preperationCounters = 0;

    public Phase phase = Phase.Main;
    public bool firstTurn = true;

    private void Awake()
    {
        mainDeck = deck.mainDeck.ToList();
        materialDeck = deck.materialDeck.ToList();
        sideboard = deck.sideboard.ToList();
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
        if (field.Count != 0)
        {
            foreach (Card card in field)
            {
                card.rested = false;
            }
        }
        
    }

    public void Materialize()
    {
        if (firstTurn)
        {
            Card spirit = null;

            foreach (Card card in materialDeck)
            {
                if (card.type1 == Type.Champion && card.subtypes[0] == Subtype.Spirit)
                {
                    spirit = card;
                }
            }
            Cast(spirit);
            materialDeck.Remove(spirit);
            lineage.Add(spirit);
            firstTurn = false;
        }
    }

    private void Cast(Card card)
    {

        if (card.type1 == Type.Champion || card.type1 == Type.Ally || card.type1 == Type.Regalia)
        {
            field.Add(card);
            foreach (CardEffect effect in card.effects)
            {
                if (effect.triggerType == TriggerType.OnEnter)
                {
                    effect.effect.ApplyEffect(this, this);
                }
            }
        }
        
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
        hand.Add(mainDeck[mainDeck.Count - 1]);
        mainDeck.Remove(mainDeck[mainDeck.Count - 1]);
    }

    internal void Discard(Card card)
    {
        graveyard.Add(card);
        hand.Remove(card);
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
