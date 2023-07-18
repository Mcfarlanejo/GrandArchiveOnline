using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Remove Level Effect", menuName = "Effect/Remove Level")]
public class RemoveLevel : Effect
{
    [SerializeField] private int level;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        target.level -= level;
    }
}
