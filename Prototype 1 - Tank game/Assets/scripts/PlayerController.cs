using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // The speed of the controller
    public float rotSpeed; // The rotaion speed of the controller

    public float hInput; //Store vales for horizontal movment
    public float vInput; //Store vales for vertical movement

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); //makes the vehical move left to right
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime); //makes the vehical move forward and backward

    }
}
