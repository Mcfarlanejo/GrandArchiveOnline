using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EffectTarget { self, champion, ally, unit }
public enum EffectArea { all, opponentOnly, selfOnly}
public abstract class Effect : ScriptableObject
{
    public EffectTarget target = EffectTarget.unit;
    public EffectArea area = EffectArea.all;

    public abstract void ApplyEffect(CardManager caster, CardManager target);
}
