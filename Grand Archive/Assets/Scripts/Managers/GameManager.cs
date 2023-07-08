using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CardManager player1;
    public CardManager player2;

    public List<Card> stack;

    // Start is called before the first frame update
    void Start()
    {
        
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
