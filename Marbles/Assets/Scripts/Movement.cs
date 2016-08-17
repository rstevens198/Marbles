using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    GameObject blueHomeExit;
    GameObject redHomeExit;
    GameObject greenHomeExit;
    GameObject yellowHomeExit;
    GameObject blueBaseEnter;
    GameObject redBaseEnter;
    GameObject greenBaseEnter;
    GameObject yellowBaseEnter;
    GameObject[] blueHome;
    GameObject[] redHome;
    GameObject[] greenHome;
    GameObject[] yellowHome;  

    void Awake()
    {
        blueHomeExit = GameObject.FindGameObjectWithTag("blueHomeExit");
        redHomeExit = GameObject.FindGameObjectWithTag("redHomeExit");
        greenHomeExit = GameObject.FindGameObjectWithTag("greenHomeExit");
        yellowHomeExit = GameObject.FindGameObjectWithTag("yellowHomeExit");
        blueBaseEnter = GameObject.FindGameObjectWithTag("blueBaseEnter");
        redBaseEnter = GameObject.FindGameObjectWithTag("redBaseEnter");
        greenBaseEnter = GameObject.FindGameObjectWithTag("greenBaseEnter");
        yellowBaseEnter = GameObject.FindGameObjectWithTag("yellowBaseEnter");
        blueHome = GameObject.FindGameObjectsWithTag("blueHome");
        redHome = GameObject.FindGameObjectsWithTag("redHome");
        greenHome = GameObject.FindGameObjectsWithTag("greenHome");
        yellowHome = GameObject.FindGameObjectsWithTag("yellowHome");
    }

    public void blueMove(GameObject marble, GameObject card)
    {
        if (card.GetComponent<Card>().value == 14)
        {

        }
        else if((card.GetComponent<Card>().value == 13) || (card.GetComponent<Card>().value == 12) || (card.GetComponent<Card>().value == 11))
        {

        }

        else if(card.GetComponent<Card>().value == 8)
        {

        }

        else if (card.GetComponent<Card>().value == 7)
        {

        }
        else if(card.GetComponent<Card>().value == 15)
        {

        }
    }

    public void redMove(GameObject marble, GameObject card)
    {

    }
}
