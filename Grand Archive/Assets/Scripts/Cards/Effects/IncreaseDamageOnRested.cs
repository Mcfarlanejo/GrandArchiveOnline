using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Increase on Rested", menuName = "Effect/Damage on Rested")]
public class IncreaseDamageOnRested : Effect
{
    [SerializeField] private int damageAmount;
    [SerializeField] Card targetCard;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        if (targetCard.rested)
        {
            GameManager.instance.stack[GameManager.instance.stack.Count].tempPower += damageAmount;
        }
    }
}
