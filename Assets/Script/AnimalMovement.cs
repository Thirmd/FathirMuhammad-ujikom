using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float speed = 2f;
    private Vector2 direction = Vector2.left;
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed){
        speed = newSpeed;
    }

    public void SetDirection(Vector2 newDirection){
        direction = newDirection;
    }
}
