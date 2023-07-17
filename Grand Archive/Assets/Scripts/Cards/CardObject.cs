using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color highlightColor = new Color32(130,130,130,255);
    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = card.artwork;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.white;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 0);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().color = highlightColor;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 0);
    }
}
