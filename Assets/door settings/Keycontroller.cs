using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycontroller : MonoBehaviour
{  
    public GameObject door; // ประตูที่จะเปิด
    private bool hasKey = false; // ตรวจสอบว่าผู้เล่นมีกุญแจหรือไม่

    void OnTriggerEnter(Collider other) 
        {
        if (other.gameObject.CompareTag("Player") && !hasKey)
            {
            hasKey = true; // ผู้เล่นได้เก็บกุญแจ
            gameObject.SetActive(false); // ซ่อนกุญแจ
        }
    }

    public void UseKey() {
        if (hasKey) {
            door.SetActive(false); // เปิดประตู
        }
    }
}
