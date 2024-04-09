using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
   public void PlayGame() {
        SceneManager.LoadSceneAsync("cutscene2 and play");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
