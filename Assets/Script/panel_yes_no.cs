using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_yes_no : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gohomePanel;
    public GameObject noMoney;
    public GameObject hidePanel;
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
        noMoney.SetActive(false);
    }
    public void yesbtn()
    {
        int count = 0;
        if (count == 0 && BehaviourScriptTest.coins >= 0)
        {
            BehaviourScriptTest.coins = BehaviourScriptTest.coins - 10;
            BehaviourScriptTest.health = BehaviourScriptTest.health + 10;
            count++;
        }
        else
        {
            noMoney.SetActive(true);
            hidePanel.SetActive(false);

        }
    }
}
