using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))    //If user hits 'R'
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       //Load particular scene
        }
    }

}
