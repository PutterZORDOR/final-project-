using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycontroller : MonoBehaviour
{  
    public GameObject door; // ��еٷ����Դ
    private bool hasKey = false; // ��Ǩ�ͺ��Ҽ������աح��������

    void OnTriggerEnter(Collider other) 
        {
        if (other.gameObject.CompareTag("Player") && !hasKey)
            {
            hasKey = true; // ���������纡ح�
            gameObject.SetActive(false); // ��͹�ح�
        }
    }

    public void UseKey() {
        if (hasKey) {
            door.SetActive(false); // �Դ��е�
        }
    }
}
