using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class restart : MonoBehaviour
    {
    public void RestartGame() {
     
            SceneManager.LoadSceneAsync("terrain");
        
    }
    public void MainMenuGame() {
     
            SceneManager.LoadSceneAsync("main menu and play");
        
   }
   
}
