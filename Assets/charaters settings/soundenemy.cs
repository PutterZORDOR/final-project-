using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundenemy : MonoBehaviour
{
    public Transform player; // ���˹觢ͧ player
    public float chaseRadius = 10f; // ����շ���ѵ�������� player
    public AudioClip chaseSound; // ���§�������������ѵ�������� player

    private AudioSource audioSource;
    private bool isChasing = false;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ��Ǩ�ͺ��� player ��������з���ѵ���������������
        if (distanceToPlayer <= chaseRadius && !isChasing) {
            // �����������§������
            audioSource.clip = chaseSound;
            audioSource.Play();
            isChasing = true;
        } else if (distanceToPlayer > chaseRadius && isChasing) {
            // ��ش������§������ ����� player �͡�͡����
            audioSource.Stop();
            isChasing = false;
        }
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRadius);
    }
}
