using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Increase for Prep", menuName = "Effect/Damage For Prep")]
public class IncreaseDamageForPrep : Effect
{
    [SerializeField] private int damageAmount;
    [SerializeField] private int prepCost;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        caster.preperationCounters -= prepCost;
        GameManager.instance.stack[GameManager.instance.stack.Count].tempPower += damageAmount;
    }
}
