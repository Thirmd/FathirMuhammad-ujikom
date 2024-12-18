using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHit : MonoBehaviour
{
    public int poin = 1;
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Animal")){
            ScoreManager.Instance.AddScore(poin);
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
}
}