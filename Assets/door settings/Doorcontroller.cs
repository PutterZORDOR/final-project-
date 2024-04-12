using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontroller : MonoBehaviour
{
    public float doorOpenAngle = 0f; // �������е٨��Դ
    public float doorCloseAngle = -90f; // �������е٨лԴ
    public float smooth = 2f; // ����������Ţͧ����Դ�Դ��е�
    private bool isReach;
    private bool openDoor = false; // ʶҹл�е��Դ���ͻԴ����
    public GameObject doorText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
         {
            isReach = true;
            doorText.SetActive(true);
            void OnGUI()
                {
                if (!openDoor) 
                    {
                }
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Reach") {
            isReach = false;
            
            
            doorText.SetActive(false);

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
