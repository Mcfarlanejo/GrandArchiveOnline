using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EffectTarget { self, champion, ally, unit }
public abstract class Effect : ScriptableObject
{
    public EffectTarget target = EffectTarget.unit;

    public abstract void ApplyEffect(CardManager caster, CardManager target);
}
