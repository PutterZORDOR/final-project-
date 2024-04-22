using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class mainmenu : MonoBehaviour
    {
    public void PlayGame() 
    {       
            SceneManager.LoadSceneAsync("cutscene2 and play");        
    }
        public void QuitGame()
     {       
            Application.Quit();
           
     }
    private void Update() {
        if (Input.GetMouseButton(0)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyUp(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


}
