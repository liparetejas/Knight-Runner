using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int damage = 1;      //Damage to knight
    public float speed;         //Speed of fire obstacles
    public GameObject effect;   //New game object called effect

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);     //To move fire obstacle constantly towards left side 
    }

    void OnTriggerEnter2D(Collider2D other)                             //Invoked when collided
    {
        if (other.CompareTag("Player"))                                     //If collided with kight
        {
            Instantiate(effect, transform.position, Quaternion.identity);   //Invoke effect          
            other.GetComponent<Player>().health -= damage;                  //Player takes damage!
            Destroy(gameObject);                                            //Destroy obstacle on collision with knight
        }
    }
    
}
