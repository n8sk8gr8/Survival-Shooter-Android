using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;


    Text scoreText;
	float survivalTime;
	GameObject player;
	PlayerHealth playerHealth;


    void Awake ()
    {
        scoreText = GetComponent <Text> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();

        score = 0;
		survivalTime = 0;
    }


    void Update ()
    {
		if(playerHealth.currentHealth > 0)
		{
			survivalTime += Time.deltaTime;
		}
        scoreText.text = "Score: " + (int)(score + survivalTime);
    }
}
