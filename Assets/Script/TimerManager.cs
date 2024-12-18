using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 60f;
    private bool isGameEnd = false;
    public Text timerText;

    void Update()
    {
        if (!isGameEnd){
            timeLeft -= Time.deltaTime;
            
            UpdateTImer();

            if(timeLeft == 0f){
                isGameEnd = true;
            }
        }
    }
    private void UpdateTImer(){
        timerText.text = "TImer: " + timeLeft;
    }
}
