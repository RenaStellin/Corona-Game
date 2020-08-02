using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class Progress_bar_script : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider slider;
    private float target = 0;
    public float Fillspeed = 0.0001f;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {
        IncreamentProgress(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < target)
        {
            slider.value += Fillspeed * Time.deltaTime;
        }
        
    }
    public void IncreamentProgress(float newProgress)
    {
        target = slider.value + newProgress;
    }
}
