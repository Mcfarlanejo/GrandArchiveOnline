using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Draw X Effect", menuName = "Effect/DrawX")]
public class DrawXEffect : Effect
{
    [SerializeField] private int baseDrawAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        int totalDrawAmount = baseDrawAmount;//+ caster.level.GetValue();
        for (int i = 0; i < totalDrawAmount; i++)
        {
            //target.Draw();
        }
    }
}
