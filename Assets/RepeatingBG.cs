using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;         //Speed with which background moves
    public float startX;        //Starting position of background on X axis
    public float endX;          //Ending position of background on X axis
    public float zPos = 7.8f;   //Constant Z position of background

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);     //Constantly move background towards left side

        if (transform.position.x <= endX)           //When ending position is reached
        {
            Vector3 pos = new Vector3(startX, transform.position.y, zPos);      
            transform.position = pos;                                           //Change position again to starting so background object spawns again
        }
    }
}
