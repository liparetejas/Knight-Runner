using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float lifetime;  //Lifetime of game objects

    private void Start()
    {
        Destroy(gameObject, lifetime);  //Destroy game objects after 'lifetime' seconds
    }
}
