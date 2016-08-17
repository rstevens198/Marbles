using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeckHandler : MonoBehaviour {

    public GameObject[] cards;
    public GameObject[] discards;
    public int counter = 0;

    GameObject temp;
    bool firstDeck = true;

    // Use this for initialization
    void Awake()
    {
        discards = new GameObject[82]; 
        Shuffle(cards);
    }

     public void Shuffle(GameObject[] list)
    {
        for( int i = 0; i < list.Length; i++)
        {
            int rand = Random.Range(0, list.Length-1);
            GameObject temp = list[rand];
            list[rand] = list[i];
            list[i] = temp;
        }
    }

    public GameObject remove()
    {
        GameObject temp;
        if (firstDeck == true)
        {
            if (counter >= 108)
            {
                Shuffle(discards);
                counter = 0; 
                firstDeck = false;
            }
            temp = cards[counter];
            counter++;
            return temp;
        }
        else
        {
            if (counter >= 82)
            {
                Shuffle(discards);
                counter = 0;
            }
            temp = discards[counter];
            counter++;
            return temp;
        }
    }

    public void addDiscards(GameObject card)
    {
        discards[counter - 1] = card;
    }
}
