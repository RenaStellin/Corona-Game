using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButtonClick : MonoBehaviour
{
    //public Sprite[] s1;
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public static int varSet;
    /*void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("DummySprites");
    }
    public void On_Click_Button(Button b)
    {
        b.image.sprite = s1[1];
    }*/
    public void Start()
    {
        b1.onClick.AddListener(delegate { ChangeImgTo1(); });
        b2.onClick.AddListener(delegate { ChangeImgTo2(); });
        b3.onClick.AddListener(delegate { ChangeImgTo3(); });
        b4.onClick.AddListener(delegate { ChangeImgTo4(); });
    }
    public void ChangeImgTo1()
    {
        varSet = 1;
    }
    public void ChangeImgTo2()
    {
        varSet = 2;
    }
    public void ChangeImgTo3()
    {
        varSet = 3;
    }
    public void ChangeImgTo4()
    {
        varSet = 4;
    }
}
