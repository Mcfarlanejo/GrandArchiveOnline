using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Add Level Effect", menuName = "Effect/Add Level")]
public class AddLevel : Effect
{
    [SerializeField] private int level;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        target.level += level;
    }
}
