using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontroller : MonoBehaviour
{
    public float doorOpenAngle = 0f; // มุมที่ประตูจะเปิด
    public float doorCloseAngle = -90f; // มุมที่ประตูจะปิด
    public float smooth = 2f; // ความนุ่มนวลของการเปิดปิดประตู

    private bool openDoor = false; // สถานะประตูเปิดหรือปิดอยู่
   

    void OnGUI() {
        if (!openDoor ) // ถ้าประตูปิดและข้อความ "Press the key E" ยังไม่ถูกแสดง
        {
            //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 20, 100, 40), "Press the key E to open the door");
           
        }
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) // ตรวจสอบว่ากดปุ่ม E หรือไม่
        {
            openDoor = !openDoor; // เปลี่ยนสถานะเปิด-ปิดประตู
            
        }

        if (openDoor) // ถ้าประตูเปิดอยู่
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0); // มุมที่เป้าหมายในการเปิดประตู
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime); // ปรับการหมุนของประตูไปที่มุมเป้าหมาย
        } else // ถ้าประตูปิดอยู่
          {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0); // มุมที่เป้าหมายในการปิดประตู
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime); // ปรับการหมุนของประตูไปที่มุมเป้าหมาย
        }
    }
}
