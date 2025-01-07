using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f; 
    private float moveDuration = 5f; 
    private float elapsedTime = 0f; 
    private bool isMoving = true; 

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Car is moving. Elapsed time: " + elapsedTime);
            elapsedTime += Time.deltaTime;

            // Stop moving after the duration has passed
            if (elapsedTime >= moveDuration)
            {
                isMoving = false;
                Debug.Log("Car stopped moving after " + elapsedTime + " seconds.");
            }
            else
            {
                Debug.Log("test");
                //hi this a new one
            } 
        }
    }
}