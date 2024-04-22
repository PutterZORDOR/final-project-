using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class skiptorestart : MonoBehaviour
{
   

    void Start() {
        // Subscribe การเรียกฟังก์ชัน OnTimelineFinished เมื่อเกิดเหตุการณ์จบแทมไลน์
        GetComponent<PlayableDirector>().stopped += OnTimelineFinished;
    }

    // เมื่อแทมไลน์จบ
    void OnTimelineFinished(PlayableDirector pd) {
        // โหลดฉากถัดไป
        SceneManager.LoadScene("restart");
    }
}
