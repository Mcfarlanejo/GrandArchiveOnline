using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
public class PlayerDeck : ScriptableObject
{
    public Card[] mainDeck;
    public Card[] materialDeck;
    public Card[] sideboard;
}
