using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float Timer;
    public Text Timer_text;

 
    void Update()
    {

            Timer += Time.deltaTime;

        Timer_text.text = "½Ã°£ : " + Mathf.Round(Timer);
    }
}
