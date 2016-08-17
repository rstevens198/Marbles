using UnityEngine;
using System.Collections;

public class UIMarbleSelect : MonoBehaviour {

    GameObject[] blueMarbles, redMarbles, greenMarbles, yellowMarbles;
    GameObject marbleSelected;
    GameObject whiteMarble;
    GameObject gameController;
    GameObject cardSelected;

    public int turn;

    void Awake()
    {
        turn = 0;

        blueMarbles = new GameObject[5];
        blueMarbles = GameObject.FindGameObjectsWithTag("blueMarble");

        redMarbles = new GameObject[5];
        redMarbles = GameObject.FindGameObjectsWithTag("redMarble");

        greenMarbles = new GameObject[5];
        greenMarbles = GameObject.FindGameObjectsWithTag("greenMarble");

        yellowMarbles = new GameObject[5];
        yellowMarbles = GameObject.FindGameObjectsWithTag("yellowMarble");

        whiteMarble = GameObject.FindGameObjectWithTag("whiteMarble");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    public void marble1Selected()
    {
        switch (turn)
        {
            case 0:
                if (gameController.GetComponent<bluePlayer>().allInBase == false)
                {
                    marbleSelected = blueMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[0].transform.position.x, .2f, blueMarbles[0].transform.position.z));
                }
                else
                {
                    marbleSelected = greenMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[0].transform.position.x, .2f, greenMarbles[0].transform.position.z));
                }
                break;
            case 1:
                if (gameController.GetComponent<redPlayer>().allInBase == false)
                {
                    marbleSelected = redMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[0].transform.position.x, .2f, redMarbles[0].transform.position.z));
                }
                else
                {
                    marbleSelected = yellowMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[0].transform.position.x, .2f, yellowMarbles[0].transform.position.z));
                }
                break;
            case 2:
                if (gameController.GetComponent<greenPlayer>().allInBase == false)
                {
                    marbleSelected = greenMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[0].transform.position.x, .2f, greenMarbles[0].transform.position.z));
                }
                else
                {
                    marbleSelected = blueMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[0].transform.position.x, .2f, blueMarbles[0].transform.position.z));
                }
                break;
            case 3:
                if (gameController.GetComponent<yellowPlayer>().allInBase == false)
                {
                    marbleSelected = yellowMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[0].transform.position.x, .2f, yellowMarbles[0].transform.position.z));
                }
                else
                {
                    marbleSelected = redMarbles[0];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[0].transform.position.x, .2f, redMarbles[0].transform.position.z));
                }
                break;
        }
    }

    public void marble2Selected()
    {
        switch (turn)
        {
            case 0:
                if (gameController.GetComponent<bluePlayer>().allInBase == false)
                {
                    marbleSelected = blueMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[1].transform.position.x, .2f, blueMarbles[1].transform.position.z));
                }
                else
                {
                    marbleSelected = greenMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[1].transform.position.x, .2f, greenMarbles[1].transform.position.z));
                }
                break;
            case 1:
                if (gameController.GetComponent<redPlayer>().allInBase == false)
                {
                    marbleSelected = redMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[1].transform.position.x, .2f, redMarbles[1].transform.position.z));
                }
                else
                {
                    marbleSelected = yellowMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[1].transform.position.x, .2f, yellowMarbles[1].transform.position.z));
                }
                break;
            case 2:
                if (gameController.GetComponent<greenPlayer>().allInBase == false)
                {
                    marbleSelected = greenMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[1].transform.position.x, .2f, greenMarbles[1].transform.position.z));
                }
                else
                {
                    marbleSelected = blueMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[1].transform.position.x, .2f, blueMarbles[1].transform.position.z));
                }
                break;
            case 3:
                if (gameController.GetComponent<yellowPlayer>().allInBase == false)
                {
                    marbleSelected = yellowMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[1].transform.position.x, .2f, yellowMarbles[1].transform.position.z));
                }
                else
                {
                    marbleSelected = redMarbles[1];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[1].transform.position.x, .2f, redMarbles[1].transform.position.z));
                }
                break;
        }
    }

    public void marble3Selected()
    {
        switch (turn)
        {
            case 0:
                if (gameController.GetComponent<bluePlayer>().allInBase == false)
                {
                    marbleSelected = blueMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[2].transform.position.x, .2f, blueMarbles[2].transform.position.z));
                }
                else
                {
                    marbleSelected = greenMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[2].transform.position.x, .2f, greenMarbles[2].transform.position.z));
                }
                break;
            case 1:
                if (gameController.GetComponent<redPlayer>().allInBase == false)
                {
                    marbleSelected = redMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[2].transform.position.x, .2f, redMarbles[2].transform.position.z));
                }
                else
                {
                    marbleSelected = yellowMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[2].transform.position.x, .2f, yellowMarbles[2].transform.position.z));
                }
                break;
            case 2:
                if (gameController.GetComponent<greenPlayer>().allInBase == false)
                {
                    marbleSelected = greenMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[2].transform.position.x, .2f, greenMarbles[2].transform.position.z));
                }
                else
                {
                    marbleSelected = blueMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[2].transform.position.x, .2f, blueMarbles[2].transform.position.z));
                }
                break;
            case 3:
                if (gameController.GetComponent<yellowPlayer>().allInBase == false)
                {
                    marbleSelected = yellowMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[2].transform.position.x, .2f, yellowMarbles[2].transform.position.z));
                }
                else
                {
                    marbleSelected = redMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[2].transform.position.x, .2f, redMarbles[2].transform.position.z));
                }
                break;
        }
    }

    public void marble4Selected()
    {
        switch (turn)
        {
            case 0:
                if (gameController.GetComponent<bluePlayer>().allInBase == false)
                {
                    marbleSelected = blueMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[3].transform.position.x, .2f, blueMarbles[3].transform.position.z));
                }
                else
                {
                    marbleSelected = greenMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[3].transform.position.x, .2f, greenMarbles[3].transform.position.z));
                }
                break;
            case 1:
                if (gameController.GetComponent<redPlayer>().allInBase == false)
                {
                    marbleSelected = redMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[3].transform.position.x, .2f, redMarbles[3].transform.position.z));
                }
                else
                {
                    marbleSelected = yellowMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[3].transform.position.x, .2f, yellowMarbles[3].transform.position.z));
                }
                break;
            case 2:
                if (gameController.GetComponent<greenPlayer>().allInBase == false)
                {
                    marbleSelected = greenMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[3].transform.position.x, .2f, greenMarbles[3].transform.position.z));
                }
                else
                {
                    marbleSelected = blueMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[3].transform.position.x, .2f, blueMarbles[3].transform.position.z));
                }
                break;
            case 3:
                if (gameController.GetComponent<yellowPlayer>().allInBase == false)
                {
                    marbleSelected = yellowMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[3].transform.position.x, .2f, yellowMarbles[3].transform.position.z));
                }
                else
                {
                    marbleSelected = redMarbles[3];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[3].transform.position.x, .2f, redMarbles[3].transform.position.z));
                }
                break;
        }
    }

    public void marble5Selected()
    {
        switch (turn)
        {
            case 0:
                if (gameController.GetComponent<bluePlayer>().allInBase == false)
                {
                    marbleSelected = blueMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[4].transform.position.x, .2f, blueMarbles[4].transform.position.z));
                }
                else
                {
                    marbleSelected = greenMarbles[2];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[4].transform.position.x, .2f, greenMarbles[4].transform.position.z));
                }
                break;
            case 1:
                if (gameController.GetComponent<redPlayer>().allInBase == false)
                {
                    marbleSelected = redMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[4].transform.position.x, .2f, redMarbles[4].transform.position.z));
                }
                else
                {
                    marbleSelected = yellowMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[4].transform.position.x, .2f, yellowMarbles[4].transform.position.z));
                }
                break;
            case 2:
                if (gameController.GetComponent<greenPlayer>().allInBase == false)
                {
                    marbleSelected = greenMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(greenMarbles[4].transform.position.x, .2f, greenMarbles[4].transform.position.z));
                }
                else
                {
                    marbleSelected = blueMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(blueMarbles[3].transform.position.x, .2f, blueMarbles[4].transform.position.z));
                }
                break;
            case 3:
                if (gameController.GetComponent<yellowPlayer>().allInBase == false)
                {
                    marbleSelected = yellowMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(yellowMarbles[4].transform.position.x, .2f, yellowMarbles[4].transform.position.z));
                }
                else
                {
                    marbleSelected = redMarbles[4];
                    whiteMarble.GetComponent<whiteMarble>().moveWhiteMarble(new Vector3(redMarbles[4].transform.position.x, .2f, redMarbles[4].transform.position.z));
                }
                break;
        }
    }

    public GameObject getSelectedMarble()
    {
        return marbleSelected;
    }

    public void turnChange()
    {
        marbleSelected = null;
        if(turn == 3)
        {
            turn = 0;
        }
        else
        {
            turn++;
        }
        whiteMarble.GetComponent<whiteMarble>().resetWhiteMarble();
        gameController.GetComponent<CameraChange>().switchCams();
        cardSelected = GetComponent<UICardSelect>().getCardSelected();
        GetComponent<UIcardLastFour>().updateCards(cardSelected);
        GetComponent<UICardSelect>().cardReset();
    }
}
