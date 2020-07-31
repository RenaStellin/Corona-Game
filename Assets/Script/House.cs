using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gohomePanel;
    public int tmpC=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        tmpC = tmpC + 1;
        Debug.Log("Housewow da "+tmpC);
        if(tmpC>1)
        {
            gohomePanel.SetActive(true);
        }

    }
}
