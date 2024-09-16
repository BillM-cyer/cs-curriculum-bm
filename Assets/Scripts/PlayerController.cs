using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public bool overworld;

    float xSpeed;
    float xDirection;
    float xVector;

    float ySpeed;
    float yDirection;
    float yVector;

    private void Start()
    {
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?

        xSpeed = 5f;
        xDirection = 0f;
        xVector = 0f;

        ySpeed = 5f;
        yDirection = 0f;
        yVector = 0f;

        if (overworld)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    private void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xSpeed * Time.deltaTime;

        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;

        transform.Translate(xVector, yVector, 0);
        
    }
    
    //for organization, put other built-in Unity functions here
    
    
    
    
    
    //after all Unity functions, your own functions go here`
}