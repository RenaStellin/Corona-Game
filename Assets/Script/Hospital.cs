﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Hospital : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Hospital");
        Instantiate(effect);

    }
}
