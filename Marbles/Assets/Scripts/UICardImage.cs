using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UICardImage : MonoBehaviour {

    GameObject card1;
    GameObject card2;
    GameObject card3;
    GameObject card4;
    GameObject card5;
    GameObject card6;

    void Awake()
    {
        card1 = GameObject.FindGameObjectWithTag("cardImage1");
        card2 = GameObject.FindGameObjectWithTag("cardImage2"); 
        card3 = GameObject.FindGameObjectWithTag("cardImage3");
        card4 = GameObject.FindGameObjectWithTag("cardImage4");
        card5 = GameObject.FindGameObjectWithTag("cardImage5");
        card6 = GameObject.FindGameObjectWithTag("cardImage6");
    }

    public void cardImagesUI(GameObject[] cards)
    {

        card1.GetComponent<Image>().sprite = cards[0].GetComponent<SpriteRenderer>().sprite;
        card2.GetComponent<Image>().sprite = cards[1].GetComponent<SpriteRenderer>().sprite;
        card3.GetComponent<Image>().sprite = cards[2].GetComponent<SpriteRenderer>().sprite;
        card4.GetComponent<Image>().sprite = cards[3].GetComponent<SpriteRenderer>().sprite;
        card5.GetComponent<Image>().sprite = cards[4].GetComponent<SpriteRenderer>().sprite;
        card6.GetComponent<Image>().sprite = cards[5].GetComponent<SpriteRenderer>().sprite;
    }

    public void testCard(GameObject card)
    {
        card1.GetComponent<Image>().sprite = card.GetComponent<SpriteRenderer>().sprite;
    }
}
