using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Fire;     //Game object fire

    void Start()
    {
        Instantiate(Fire, transform.position, Quaternion.identity);     //Spawn fire beyond right side of screen
    }
}
