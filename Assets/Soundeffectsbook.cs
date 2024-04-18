using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffectsbook : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    public void book() 
    {
        if (Input.GetKeyUp(KeyCode.R)) {
            src.clip = sfx1;
            src.Play();
        }
    }
    public void book2() 
    {
        src.clip = sfx1;
        src.Play();
    }
    public void book3() {
        src.clip = sfx1;
        src.Play();
    }
}
