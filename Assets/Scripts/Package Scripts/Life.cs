using System;
using UnityEngine;

public class Life : MonoBehaviour
{
    GameManager gm;

    void Start ()
    {
        gm = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            gm.Health -= 5;

            if (gm.Health <= 0)
            {
                gm.Health = 100;

                gm.score -= 5;
                gm.coinText.text = "-Cash- " + gm.score;
                
                Debug.Log("-Cash- " + gm.score);

                if (gm.score < 0)
                {
                    print(" Womp womp ");
                }
            }
            
            Debug.Log("-Health- " + gm.Health);
            gm.healthText.text = "-Health- " + gm.Health;

        }
    }
}

