using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] FirePattern;    //Array of game objects
    private float timeBtwSpawn;         //Time between successive spawns
    public float startTimeBtwSpawn;     //Starting time
    public float decreaseTime;          //Decreasing time so as to make game difficult
    public float minTime = 0.65f;       //Minimum playable time

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, FirePattern.Length);     //Random integer in range 0 to length of array
            Instantiate(FirePattern[rand], transform.position, Quaternion.identity);    //Invoke random fire obstacle pattern
            timeBtwSpawn = startTimeBtwSpawn;           //Equating to start time
            
            if (startTimeBtwSpawn > minTime)            //Limiting condition
            {
                startTimeBtwSpawn -= decreaseTime;      //Decrement time
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;             //Decrement time
        }
    }
}
