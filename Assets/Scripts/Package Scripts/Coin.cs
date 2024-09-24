using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class Coins : MonoBehaviour
{
    GameManager gm;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            gm.score += 1;
            Destroy(other.gameObject);
            Debug.Log("-Cash- " + gm.score);
            gm.coinText.text = "-Cash- " + gm.score;
        }
    }
}
