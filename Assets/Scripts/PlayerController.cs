using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float xSpeed = 5f;
    private float xVector = 0f;

    private Rigidbody2D rb;

    public bool overworld; 

    private void Start()
    {
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?
        
        
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
        
    }
    
    //for organization, put other built-in Unity functions here
    
    
    
    
    
    //after all Unity functions, your own functions go here`
}