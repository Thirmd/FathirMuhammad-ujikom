using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;
    public int scoreMinus = 3;
    private void Awake() {
        if (Instance == null){
            Instance = this;}
    }
    void Start()
    {
        score = 0;
    }
    public void AddScore(int poin){
        score += poin;
        Debug.Log(score);
    }
    public void DelScore(int poin){
        if (score < scoreMinus){
            score = 0;
        Debug.Log(score);
        }
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Animal")){
            DelScore(scoreMinus);
        }
    }
}