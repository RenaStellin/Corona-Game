using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    public void changeFirstScreen(string screenname)
    {
        Application.LoadLevel(screenname);
    }
    public void resetHealth()
    {
        BehaviourScriptTest.health = 100;
    }
   
}
