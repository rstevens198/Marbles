using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    GameObject temp;
    public GameObject test;
    GameObject mC;


    void Awake()
    {
        mC = GameObject.FindGameObjectWithTag("MainCanvas");

    }

    void Start()
    { 

        
        GetComponent<bluePlayer>().getCard(0);
        GetComponent<bluePlayer>().getCard(1);
        GetComponent<bluePlayer>().getCard(2);
        GetComponent<bluePlayer>().getCard(3);
        GetComponent<bluePlayer>().getCard(4);
        GetComponent<bluePlayer>().getCard(5);
   
        mC.GetComponent<UICardImage>().cardImagesUI(GetComponent<bluePlayer>().hand);

    }

    

}
