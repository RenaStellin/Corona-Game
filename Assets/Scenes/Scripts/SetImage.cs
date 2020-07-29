using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImage : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] s1;
    public GameObject img;
    void Start()
    {
        //s1 = Resources.LoadAll<Sprite>("DummySprites");

        if (CheckButtonClick.varSet == 1)
            img.GetComponent<Image>().sprite = s1[0];
        if (CheckButtonClick.varSet == 2)
            img.GetComponent<Image>().sprite = s1[1];
        if (CheckButtonClick.varSet == 3)
            img.GetComponent<Image>().sprite = s1[2];
        if (CheckButtonClick.varSet == 4)
            img.GetComponent<Image>().sprite = s1[3];
    }
}
