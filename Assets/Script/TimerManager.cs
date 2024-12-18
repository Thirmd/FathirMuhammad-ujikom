using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timeLeft;
    private bool isGameEnd = false;
    public Text timerText;
    public GameObject GameEndUI;

    void Start(){
        GameEndUI.SetActive(false);
    }
    void Update()
    {
        if (!isGameEnd){
            timeLeft -= Time.deltaTime;
            
            UpdateTImer();

            if(timeLeft <= 0f){
                isGameEnd = true;
                timerText.text = "TImer: 0";
                GameEndUI.SetActive(true);
            }
        }
    }
    private void UpdateTImer(){
        timerText.text = "TImer: " + timeLeft;
    }
}
