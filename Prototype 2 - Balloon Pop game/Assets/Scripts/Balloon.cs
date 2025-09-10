using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.15f; //Scale increased each time the balloon is clicked

    public int scoreToGive; //Score given for popped balloon.

    private ScoreManager scoreManager; // A variable to reference the ScoreManager

    public GameObject popEffect; //Reference Pop Effect Particle System

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        //Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if the ballon has popped
        if(clickToPop == 0)
        {
            Destroy(gameObject); // pop the balloon
        }
    }
}
