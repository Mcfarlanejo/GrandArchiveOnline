using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color highlightColor = new Color32(255,255,255,255);
    public Card card;
    public Touch touch;
    public GameObject castMenu;
    public Button castButton;
    private GameObject newCastMenu;

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
                    OnHover(touch);
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

    private void OnHover(Touch touch)
    {
        GetComponent<Image>().color = highlightColor;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 0);
        if (newCastMenu == null)
        {
            newCastMenu = Instantiate(castMenu, gameObject.transform);
            newCastMenu.transform.position = touch.position;
            castButton = newCastMenu.GetComponentInChildren<Button>();
            castButton.onClick.AddListener(CastCard);
        }
    }
    private void OnExit()
    {
        GetComponent<Image>().color = Color.white;
        gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 0);
        StartCoroutine(DestroyCastMenu());
    }

    private IEnumerator DestroyCastMenu()
    {
        yield return new WaitForSeconds(2.5f);
        castButton = null;
        Destroy(newCastMenu);
    }

    private void CastCard()
    {
        if (gameObject.transform.GetComponentInParent<ScrollRect>().transform.name == "Player 1*")
        {
            GameManager.instance.ResolveCard(card, "player1");
        }
        else
        {
            GameManager.instance.ResolveCard(card, "player2");
        }
        
    }
}
