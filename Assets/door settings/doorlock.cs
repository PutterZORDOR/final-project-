using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour
{
    public GameObject door; // ��еٷ����Դ
    private bool isOpen = false;

    void OnTriggerEnter(Collider other) 
        {
        if (other.gameObject.CompareTag("Key")) 
            {
            // ����һ�е��ѧ����Դ����
            if (!isOpen) 
                {
                // �Դ��е�
                door.SetActive(false);
                isOpen = true;
            }
        }
    }
   
}
