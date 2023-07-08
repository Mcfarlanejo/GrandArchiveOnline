using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuButtons : MonoBehaviour
{
    public GameObject mainButtons;
    public GameObject join;
    public GameObject host;

    public void Join()
    {
        Debug.Log("Join Game");
        mainButtons.SetActive(false);
        join.SetActive(true);
    }

    public void Host()
    {
        Debug.Log("Host Game");
        mainButtons.SetActive(false);
        host.SetActive(true);
    }

    public void DeckBuilder()
    {
        Debug.Log("Open Deck Builder");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        host.SetActive(false);
        join.SetActive(false);
        mainButtons.SetActive(true);
    }
}
