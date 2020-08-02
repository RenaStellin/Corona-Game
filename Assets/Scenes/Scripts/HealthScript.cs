using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BehaviourScriptTest.health <= 0)
        {
            GameOverPanel.SetActive(true);
        }
    }
}
