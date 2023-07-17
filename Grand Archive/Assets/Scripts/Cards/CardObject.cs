using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color highlightColor = new Color32(130,130,130,255);
    public Card card;
    public Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = card.artwork;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            Image i = GetComponent<Image>();
            float spriteWidth = 250;
            float spriteHeight = 350;
            float leftEdge = transform.position.x - (spriteWidth / 2);
            float rightEdge = transform.position.x + (spriteWidth / 2);
            float topEdge = transform.position.y + (spriteHeight / 2);
            float bottomEdge = transform.position.y - (spriteHeight / 2);

            if (touch.position.x > leftEdge && touch.position.x < rightEdge && 
                touch.position.y < topEdge && touch.position.y > bottomEdge)
            {
                Debug.Log(gameObject.name);
                if (touch.phase == TouchPhase.Began)
                {
                    OnHover();
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    OnExit();
                }
            }
            
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //OnExit();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //OnHover();
    }

    private void OnHover()
    {
        GetComponent<Image>().color = highlightColor;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 0);
    }
    private void OnExit()
    {
        GetComponent<Image>().color = Color.white;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 0);
    }
}
