using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Keycontroller keyController;

    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) 
            {
            keyController.UseKey();
        }
    }
}

      


