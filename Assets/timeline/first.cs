using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    void Start() {
       
        GetComponent<PlayableDirector>().stopped += OnTimelineFinished;
    }

  
    void OnTimelineFinished(PlayableDirector pd) {
       
        SceneManager.LoadScene("terrain");
    }
    public void QuitGame() 
    {

        Application.Quit();
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("terrain");
        }
       
    }
}
