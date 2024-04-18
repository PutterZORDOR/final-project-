using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteinbook : MonoBehaviour
{
    [SerializeField]
    private RawImage _noteImage;
    public GameObject MessagePanel;
    public bool Action = false;

    public void Start() {
        MessagePanel.SetActive(false);
    }
    public void Update() {
        if(Input.GetKeyUp(KeyCode.R)) 
        {
            if (Action == true) 
            {
                MessagePanel.SetActive(false);
                Action = false;
                _noteImage.enabled = true;
            } 
        }
    }
    private void OnTriggerEnter(Collider other) 
        {
        if (other.CompareTag("Player")) 
         {
            MessagePanel.SetActive(true);
            Action = true;
        }
    }
    private void OnTriggerExit (Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            MessagePanel.SetActive(false);
            Action = false;
            _noteImage.enabled = false;
        }
    }
}
