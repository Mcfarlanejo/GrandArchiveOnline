using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Both Players Draw Effect", menuName = "Effect/Both Players Draw")]
public class BothPlayersDrawEffect : Effect
{
    [SerializeField] private int casterDrawAmount = 0;
    [SerializeField] private int opponentDrawAmount = 0;
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        for (int i = 0; i < casterDrawAmount; i++)
        {
            caster.DrawCard();
        }
        for (int i = 0; i < opponentDrawAmount; i++)
        {
            target.DrawCard();
        }
    }
}
