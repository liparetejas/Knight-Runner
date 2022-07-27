using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;       //Starting score 0
    public Text scorePoints;    //Document score
    private void Update()
    {
        scorePoints.text = score.ToString();    //Prints score
    }

    void OnTriggerEnter2D(Collider2D other)     //When fire obstacles collie with left wall
    {
        if (other.CompareTag("Fire") && GameObject.Find("Player").GetComponent<Player>().health > 0)    //Only increment while game is processing
        {
            score++;
        }
    }
}
