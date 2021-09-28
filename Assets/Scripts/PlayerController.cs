using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Wheels frontWheels; //Wheels sınıfı frontWheels değişken olarak eklendik
    public float speed = 5f;
    public float turnSpeed;
    public float horizontalInput;
    private float forwardInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        if (forwardInput != 0) //Eğer forwardInput 0'dan farklı ise araç dönsün. 
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontalInput);
        }

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);

      
        
        //Her iki tekerlek döndürülür.
        frontWheels.SetAngle(horizontalInput).TurnRight().TurnLeft(); 

    }
}
