using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float movementSpeed = 350;
    void Update()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(HorizontalMove, 0f, 0f) * movementSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
