using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Glimpse X Effect", menuName = "Effect/GlimpseX")]
public class GlimpseXEffect : Effect
{
    [SerializeField] private int baseGlimpseAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        int totalGlimpseAmount = baseGlimpseAmount + (caster.level + caster.levelCounters);

        target.Glimpse(totalGlimpseAmount);
    }
}
