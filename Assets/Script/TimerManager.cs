using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 60f;
    private bool isGameEnd = false;
    void Update()
    {
        if (!isGameEnd){
            timeLeft -= Time.deltaTime;
            
            Debug.Log("timer: " + timeLeft);

            if(timeLeft == 0f){
                isGameEnd = true;
            }
        }
    }
}
