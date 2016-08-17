using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

    public Camera mainCam;
    public Camera switchCam;

	void Awake()
    {
        mainCam.enabled = true;
        switchCam.enabled = false;
    }
    public void switchCams()
    {
        if(mainCam.enabled == true)
        {
            switchCam.enabled = true;
            mainCam.enabled = false;
        }
        else
        {
            mainCam.enabled = true;
            switchCam.enabled = false;
        }
    }
}
