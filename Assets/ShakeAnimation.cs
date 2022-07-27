using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeAnimation : MonoBehaviour
{
    public Animator camAnim;    //Instance of class Animator

    public void CamShake()
    {
        int rand = Random.Range(0, 3);  //Invoke random integer
        if (rand == 0)
        {
            camAnim.SetTrigger("shake");    //Invoke 'shake' animation
        }
        else if (rand == 1)
        {
            camAnim.SetTrigger("shake1");   //Invoke 'shake1' animation
        }
        else if (rand == 2)
        {
            camAnim.SetTrigger("shake2");   //Invoke 'shake2' animation
        }
        
    }
}
