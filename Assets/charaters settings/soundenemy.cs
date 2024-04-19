using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundenemy : MonoBehaviour
{
    public Transform player; // ตำแหน่งของ player
    public float chaseRadius = 10f; // รัศมีที่วัตถุไล่ล่า player
    public AudioClip chaseSound; // เสียงที่จะเล่นเมื่อวัตถุไล่ล่า player

    private AudioSource audioSource;
    private bool isChasing = false;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ตรวจสอบว่า player อยู่ในระยะที่วัตถุไล่ล่าหรือไม่
        if (distanceToPlayer <= chaseRadius && !isChasing) {
            // เริ่มเล่นเสียงไล่ล่า
            audioSource.clip = chaseSound;
            audioSource.Play();
            isChasing = true;
        } else if (distanceToPlayer > chaseRadius && isChasing) {
            // หยุดเล่นเสียงไล่ล่า เมื่อ player ออกนอกระยะ
            audioSource.Stop();
            isChasing = false;
        }
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRadius);
    }
}
