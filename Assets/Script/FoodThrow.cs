using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodThrow : MonoBehaviour
{
    public GameObject FoodPrefab;
    public float foodSpeed = 300;
    public float foodLifetime = 3f;
    public float positionOffset =3f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Throw();
        }
    }

    void Throw(){
        Vector3 foodPosition = transform.position + transform.forward * positionOffset;

        GameObject Food = Instantiate(FoodPrefab, foodPosition, transform.rotation);

        Rigidbody rigidbody = Food.GetComponent<Rigidbody>();

        if(rigidbody != null){
            rigidbody.AddForce(transform.forward * foodSpeed, ForceMode.Impulse);
        }

        Destroy(Food, foodLifetime);
    }

    void OnTriggerEnter(Collider other) {
        
    }
}
