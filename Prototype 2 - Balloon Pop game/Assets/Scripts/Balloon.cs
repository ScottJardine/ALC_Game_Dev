using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.15f; //Scale increased each time the balloon is clicked

    public int scoreToGive; //Score given for popped balloon.

    private ScoreManager scoreManager; // A variable to reference the ScoreManager

    public GameObject popEffect; //Reference Pop Effect Particle System

    // Update is called once per frame

void Start
    {
        //reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager")
        GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        //Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
    // Check to see if the ballon has popped
    if (clickToPop == 0)
        {
        scoreManager.IncreaseScoreText(scoreToGive); //Increase score
        //Instantiate (popEffect, transform.position, transfrom.rotation); // Instantiate Pareticle Effect - POP Effect"
            Destroy(gameObject); // pop the balloon
        }
    }
}
