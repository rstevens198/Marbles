using UnityEngine;
using System.Collections;

public class bluePlayer : MonoBehaviour
{

    public GameObject[] marbles;
    public GameObject[] hand;
    public bool allInBase;
    public int lastPosition;
    GameObject UI;

    void Awake()
    {
        marbles = GameObject.FindGameObjectsWithTag("blueMarble");
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
        lastPosition = position;
    }

    public void displayHand()
    {
        UI.GetComponent<UICardImage>().cardImagesUI(hand);
    }
}
