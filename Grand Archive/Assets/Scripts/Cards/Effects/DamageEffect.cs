using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Effect", menuName = "Effect/Damage")]
public class DamageEffect : Effect
{
    [SerializeField] private int damageAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        //target.Damage(damageAmount);
    }
}
