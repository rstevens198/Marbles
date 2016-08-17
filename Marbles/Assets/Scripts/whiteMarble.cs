using UnityEngine;
using System.Collections;

public class whiteMarble : MonoBehaviour {

    GameObject marble;
    Vector3 oP;

    void Awake()
    {
        marble = GameObject.FindGameObjectWithTag("whiteMarble");
        oP = new Vector3(0, -2, 0);
    }

    public void moveWhiteMarble(Vector3 move)
    {
        marble.transform.position = move;
    }

    public void resetWhiteMarble()
    {
        marble.transform.position = oP;
    }
}
