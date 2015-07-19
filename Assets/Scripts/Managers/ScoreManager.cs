using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;


    Text scoreText;
	float survivalTime;


    void Awake ()
    {
        scoreText = GetComponent <Text> ();
        score = 0;
		survivalTime = 0;
    }


    void Update ()
    {
		survivalTime += Time.deltaTime;
        scoreText.text = "Score: " + (int)(score + survivalTime);
    }
}
