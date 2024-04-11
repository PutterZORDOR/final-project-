using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour
{
    public GameObject door; // ประตูที่จะเปิด
    private bool isOpen = false;

    void OnTriggerEnter(Collider other) 
        {
        if (other.gameObject.CompareTag("Key")) 
            {
            // เช็คว่าประตูยังไม่เปิดอยู่
            if (!isOpen) 
                {
                // เปิดประตู
                door.SetActive(false);
                isOpen = true;
            }
        }
    }
   
}
