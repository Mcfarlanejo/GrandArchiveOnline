using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardObject : MonoBehaviour
{
    private Color highlightColor = new Color32(130,130,130,255);
    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = card.artwork;
    }

    private void OnMouseOver()
    {
        Debug.Log("Over");
        GetComponent<Image>().color = highlightColor;
    }

    private void OnMouseExit()
    {
        Debug.Log("Exited");
        GetComponent<Image>().color = Color.white;
    }
}
