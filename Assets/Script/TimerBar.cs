using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using System;
using UnityEngine.SceneManagement;
public class TimerBar : MonoBehaviour
{
    public GameObject bar;
    public GameObject Panel;
    public int time;
    public int timestart = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
        Invoke("OpenPanel", time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
        
    }
    public void OpenPanel()
    {
        Panel.SetActive(true);
        BehaviourScriptTest.health = BehaviourScriptTest.health - 30;
    }

   
    
}
