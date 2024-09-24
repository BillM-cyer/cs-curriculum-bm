using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public int Health;

    public static GameManager gm;

    public TestMeshProUGUI coinText;
    public TestMeshProUGUI healthText;
    public void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        Health = 100;
        Debug.Log("-Health- ");

        coinText.text = "-Cash- " + score;
        healthText.text = "-Health- " + Health;
    }

    void Update()
    {
        
    }
}
