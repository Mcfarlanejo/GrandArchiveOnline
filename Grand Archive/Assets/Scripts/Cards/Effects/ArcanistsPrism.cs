using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Arcanist's Prism Effect", menuName = "Effect/Unique/Arcanist's Prism")]
public class ArcanistsPrism : Effect
{
    public override void ApplyEffect(CardManager caster, CardManager target)
    {
        //if (GameManager.instance.phase == recollection)
        //{
        //  int cardCount = 0;
        //  foreach(Card card in target.Hand)
        //  {
        //      target.deck.PlaceOnBottom(card);
        //      cardCount++;
        //  }
        //  for(int i = 0; i < cardCount; i++)
        //  {
        //      target.Draw();
        //  }
        //}
    }
}
