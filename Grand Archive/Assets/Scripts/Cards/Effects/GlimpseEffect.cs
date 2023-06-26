using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Glimpse Effect", menuName = "Effect/Glimpse")]
public class GlimpseEffect : Effect
{
    [SerializeField] private int glimpseAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        //target.Glimpse(glimpseAmount);
    }
}
