using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontroller : MonoBehaviour
{
    public float doorOpenAngle = 0f; // �������е٨��Դ
    public float doorCloseAngle = -90f; // �������е٨лԴ
    public float smooth = 2f; // ����������Ţͧ����Դ�Դ��е�

    private bool openDoor = false; // ʶҹл�е��Դ���ͻԴ����
   

    void OnGUI() {
        if (!openDoor ) // ��һ�еٻԴ��Т�ͤ��� "Press the key E" �ѧ���١�ʴ�
        {
            //GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 20, 100, 40), "Press the key E to open the door");
           
        }
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) // ��Ǩ�ͺ��ҡ����� E �������
        {
            openDoor = !openDoor; // ����¹ʶҹ��Դ-�Դ��е�
            
        }

        if (openDoor) // ��һ�е��Դ����
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0); // �������������㹡���Դ��е�
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime); // ��Ѻ�����ع�ͧ��е�价������������
        } else // ��һ�еٻԴ����
          {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0); // �������������㹡�ûԴ��е�
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime); // ��Ѻ�����ع�ͧ��е�价������������
        }
    }
}
