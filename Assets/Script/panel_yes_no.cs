using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_yes_no : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gohomePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nobtn()
    {
        gohomePanel.SetActive(false);
    }
}
