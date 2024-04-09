using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("terrain");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
