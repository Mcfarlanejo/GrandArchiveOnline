using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Add Enlighten Effect", menuName = "Effect/Enlighten")]
public class EnlightenEffect : Effect
{
    [SerializeField] private int enlightenAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        target.enlightenCounters += enlightenAmount; 
    }
}
