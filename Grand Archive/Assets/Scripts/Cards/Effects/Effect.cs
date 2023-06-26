using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EffectTarget { self, opponent }
public abstract class Effect : ScriptableObject
{
    public EffectTarget target = EffectTarget.opponent;

    public abstract void ApplyEffect(CardManager caster, CardManager target);
}
