using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;
    public int scoreMinus = 0; 
    public Text scoreText;
    private void Awake() {
        if (Instance == null){
            Instance = this;
        }
    }
    void Start()
    {
        score = 0;
        UpdateScore();

    }
    public void AddScore(int poin){
        score += poin;
        UpdateScore();
    }
    private void UpdateScore(){
        scoreText.text = "Score: " + score;
    }
    public void DelScore(int poin){
        if (score < scoreMinus){
            score = 0;
        UpdateScore();
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Animal")){
            DelScore(scoreMinus);
        }
    }
}