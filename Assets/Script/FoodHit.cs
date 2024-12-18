using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Animal")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
}
}