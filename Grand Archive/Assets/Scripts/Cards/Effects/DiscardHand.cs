using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Discard Hand", menuName = "Effect/Discard Hand")]
public class DiscardHand : Effect
{
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        foreach (Card card in target.hand)
        {
            target.Discard(card);
        }
    }
}
