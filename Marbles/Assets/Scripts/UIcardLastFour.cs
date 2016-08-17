using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIcardLastFour : MonoBehaviour {

    GameObject card1;
    GameObject card2;
    GameObject card3;
    GameObject card4;

    void Awake()
    {
        card1 = GameObject.FindGameObjectWithTag("cardLast1");
        card2 = GameObject.FindGameObjectWithTag("cardLast2");
        card3 = GameObject.FindGameObjectWithTag("cardLast3");
        card4 = GameObject.FindGameObjectWithTag("cardLast4");
    }

    public void updateCards(GameObject card)
    {
        if(card3.GetComponent<Image>().sprite != null)
            card4.GetComponent<Image>().sprite = card3.GetComponent<Image>().sprite;
        if(card2.GetComponent<Image>().sprite)
            card3.GetComponent<Image>().sprite = card2.GetComponent<Image>().sprite;
        if (card1.GetComponent<Image>().sprite)
            card2.GetComponent<Image>().sprite = card1.GetComponent<Image>().sprite;
        card1.GetComponent<Image>().sprite = card.GetComponent<SpriteRenderer>().sprite;
    }
}
