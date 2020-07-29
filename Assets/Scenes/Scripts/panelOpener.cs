using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelOpener : MonoBehaviour
{
    public GameObject Panel;
    public Text q;
    public Text a1;
    public Text a2;
    public Text a3;
    public Text a4;
    public GameObject resPanel;
    public Text res;
    // private int coins = 0;
    public Text healthText;
    string[] qs = System.IO.File.ReadAllLines("qs.txt");
    // public string[] qs = {"script q1", "script q2", "script q3", "script q4"};
    public string[] as1 = {"script a1q1", "script a1q2", "script a1q3", "script a1q4"};
    public string[] as2 = {"script a2q1", "script a2q2", "script a2q3", "script a2q4"};
    public string[] as3 = {"script a3q1", "script a3q2", "script a3q3", "script a3q4"};
    public string[] as4 = {"script a4q1", "script a4q2", "script a4q3", "script a4q4"};
    public string[] key = {"1,2,3,4","4,1,2,3","1,4,2,3","1,2,4,3"};
    // public int q_num = 0;
    // Start is called before the first frame update
    public void OpenPanel()
    {
        if(Panel.activeSelf==false)
        {
            int q_num = BehaviourScriptTest.q_num;
            q.text = qs[q_num];
            a1.text = as1[q_num];
            a2.text = as2[q_num];
            a3.text = as3[q_num];
            a4.text = as4[q_num];
            Panel.SetActive(true);
        }

    }

    public void answerClick(int ansVal)
    {
        int user_score = deriveScore(ansVal);
        // healthText.text = "Coins :" + user_score;
        BehaviourScriptTest.coins = BehaviourScriptTest.coins+ user_score;
        Panel.SetActive(false);
        resPanel.SetActive(true);
        BehaviourScriptTest.q_num = BehaviourScriptTest.q_num + 1;
        if(BehaviourScriptTest.q_num==4)
        {
            BehaviourScriptTest.q_num = 0;
        }
        int q_num = BehaviourScriptTest.q_num;
        q.text = qs[q_num];
        a1.text = as1[q_num];
        a2.text = as2[q_num];
        a3.text = as3[q_num];
        a4.text = as4[q_num];
    }
    public int deriveScore(int user_selected)
    {
        int q_num = BehaviourScriptTest.q_num;
        string[] authorsList = key[q_num].Split(',');
        int m_ind = 0;  
        int coins=0;
        foreach (string author in authorsList)
        {
            m_ind = m_ind + 1;
            if(author == user_selected.ToString())
            {
                break;
            }
        }
        if(m_ind==1)
        {
            coins = 15;
            res.text = "Perfect +15";
        }
        else if(m_ind==2)
        {
            coins = 10;
            res.text = "Correct, but not perfect +10";
        }
        else if(m_ind==3)
        {
            coins = 5;
            res.text = "Partially correct +5";
        }
        else if(m_ind==4)
        {
            coins = -5;
            res.text = "Wrong answer -5";
        }
        // Console.WriteLine(author); 
        return coins;
    }
    public void nxtbtnClick()
    {
        resPanel.SetActive(false);
        Panel.SetActive(true);
    }
}
