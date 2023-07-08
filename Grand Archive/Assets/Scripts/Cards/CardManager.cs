using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public PlayerDeck deck;
    private List<Card> mainDeck = new List<Card>();
    private List<Card> materialDeck = new List<Card>();
    private List<Card> sideboard = new List<Card>();

    public List<Card> hand = new List<Card>();
    public List<Card> memory = new List<Card>();

    public int damageCounters = 0;
    public int lifeTotal;
    public int level;
    public int levelCounters;
    public int enlightenCounters = 0;

    private void Awake()
    {
        mainDeck.Equals(deck.mainDeck);
        materialDeck.Equals(deck.materialDeck);
        sideboard.Equals(deck.sideboard);
    }

    public void Damage(int amount)
    {
        damageCounters += amount;
    }

    public void Draw()
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
            Draw();
        }
    }
}
