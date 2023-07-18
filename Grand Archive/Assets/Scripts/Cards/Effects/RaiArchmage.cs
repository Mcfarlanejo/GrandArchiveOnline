using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rai, Archmage Effect", menuName = "Effect/Unique/Rai, Archmage")]
public class RaiArchmage : Effect
{
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        int turn = 0;
        if (turn != GameManager.instance.turnCount)
        {
            turn = GameManager.instance.turnCount;
            caster.enlightenCounters += 1;
        }
    }
}
