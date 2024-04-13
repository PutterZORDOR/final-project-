using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    public void QuitGame() 
    {

        Application.Quit();
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
         {
            SceneManager.LoadScene("terrain");
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            SceneManager.LoadScene("terrain");
        }
    }
}
