 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coins = 0;
    public static int health = 100;
    public static int q_num = 0;
    public Text healthText;
    public Text coinText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins :" + coins;
        healthText.text = "Health :" + health;
        // DontDestroyOnLoad(coinText);
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     coins++;
        // }
    }
}
