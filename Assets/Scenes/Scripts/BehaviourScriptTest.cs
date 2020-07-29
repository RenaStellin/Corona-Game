 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coins = 0;
    public static int q_num = 0;
    public Text healthText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Coins :" + coins;
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     coins++;
        // }
    }
}
