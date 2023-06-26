using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enlighten X Effect", menuName = "Effect/EnlightenX")]
public class AddXEnlightenEffect : Effect
{
    [SerializeField] private int baseEnlightenAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        //target.enlightenCounter += baseEnlightenAmount + caster.level.GetValue();
    }
}
