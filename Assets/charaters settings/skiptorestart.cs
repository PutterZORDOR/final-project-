using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class skiptorestart : MonoBehaviour
{
   

    void Start() {
        // Subscribe ������¡�ѧ��ѹ OnTimelineFinished ������Դ�˵ء�ó쨺���Ź�
        GetComponent<PlayableDirector>().stopped += OnTimelineFinished;
    }

    // ��������Ź쨺
    void OnTimelineFinished(PlayableDirector pd) {
        // ��Ŵ�ҡ�Ѵ�
        SceneManager.LoadScene("restart");
    }
}
