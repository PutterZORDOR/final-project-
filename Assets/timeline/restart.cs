using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class restart : MonoBehaviour
    {
    public void RestartGame() {
        if (Input.GetMouseButton(0)) {
            SceneManager.LoadSceneAsync("terrain");
        }
    }
    public void MainMenuGame() {
        if (Input.GetMouseButton(0)) {
            SceneManager.LoadSceneAsync("main menu and play");
        }
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
