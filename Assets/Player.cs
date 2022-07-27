using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;  //Position of knight
    public float yIncrement;    //Variable to set by how many position should your knight move up or down when you hit key one time
    public float speed;         //Variable to set speed with which your knight should move up and down
    public float maxHeight;     //Upper limit
    public float minHeight;     //Lower limit
    public int health = 3;      //Health
    public GameObject effect;   //New gameobject called effect
    private ShakeAnimation shake;   //Camera shaking while movement of knight
    public Text hitPoints;          //Document HP
    public GameObject gameOver;     //For game over scene

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<ShakeAnimation>(); //Shake animation assigned to shake instance
    }

    private void Update()
    {
        hitPoints.text = health.ToString(); //Document HP


        if (health <= 0)    
        {
            gameOver.SetActive(true);   //Set game over as active scene
            Destroy(gameObject);        //Destroy knight after game is over
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);    //To set new position of knight 

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)                          //Check UpArrow and upper limit of screen
        {
            Instantiate(effect, transform.position, Quaternion.identity);                           //Invoke effect
            shake.CamShake();                                                                       //Invoke CamShake
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);       //Update position of knight
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)                   //Check DownArrow and lower limit of screen
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            shake.CamShake();
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }
}
