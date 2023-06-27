using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Draw Effect", menuName = "Effect/Draw")]
public class DrawEffect : Effect
{
    [SerializeField] private int drawAmount;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        for (int i = 0; i < drawAmount; i++)
        {
            target.Draw();
        }
    }
}
