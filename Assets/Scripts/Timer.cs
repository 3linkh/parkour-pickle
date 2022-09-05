using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerCanvasText;
    public float gameTime;

    public bool updateTime = true;
    

    public void StopTimeDisplay()
    {   
        print ("Time Left: 0");
        timerCanvasText.text = "Time Left: 0";
            
        
    }
   

    public void ReduceTime()
    {
        
        gameTime -= Time.deltaTime;
        
        timerCanvasText.text = "Time Left: " + gameTime;
    }

}
