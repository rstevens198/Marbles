using UnityEngine;
using System.Collections;

public class UICardSelect : MonoBehaviour {

    GameObject[] cards;
    GameObject turn;
    GameObject gameController;
    GameObject cardSelected;

    void Awake()
    {
        cards = new GameObject[6];
        turn = GameObject.FindGameObjectWithTag("MainCanvas");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    public void getCards()
    {
        switch (turn.GetComponent<UIMarbleSelect>().turn)
        {
            case 0:
                cards = gameController.GetComponent<bluePlayer>().hand;
                break;
            case 1:
                cards = gameController.GetComponent<redPlayer>().hand;
                break;
            case 2:
                cards = gameController.GetComponent<greenPlayer>().hand;
                break;
            case 3:
                cards = gameController.GetComponent<yellowPlayer>().hand;
                break;
        }
    }

    public void card1Selected()
    {
        cardSelected = cards[0];
    }

    public void card2Selected()
    {
        cardSelected = cards[1];
    }

    public void card3Selected()
    {
        cardSelected = cards[2];
    }

    public void card4Selected()
    {
        cardSelected = cards[3];
    }

    public void card5Selected()
    {
        cardSelected = cards[4];
    }

    public void card6Selected()
    {
        cardSelected = cards[5];
    }

    public GameObject getCardSelected()
    {
        if (cardSelected != null)
            return cardSelected;
        else
            return null;
    } 

    public void cardReset()
    {
        cardSelected = null;
    }
}
