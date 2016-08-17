using UnityEngine;
using System.Collections;

public class redPlayer : MonoBehaviour
{

    public GameObject[] marbles;
    public GameObject[] hand;
    public bool allInBase;
    GameObject UI;

    void Awake()
    {
        marbles = GameObject.FindGameObjectsWithTag("redMarble");
        hand = new GameObject[6];
        allInBase = false;
        UI = GameObject.FindGameObjectWithTag("MainCanvas");
    }

    public void getCard(int position)
    {
        hand[position] = GetComponent<DeckHandler>().remove();
    }

    public void discardCard(int position)
    {
        GetComponent<DeckHandler>().addDiscards(hand[position]);
    }

    public void displayHand()
    {
        UI.GetComponent<UICardImage>().cardImagesUI(hand);
    }
}
