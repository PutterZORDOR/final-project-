using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class skiptomainmenu : MonoBehaviour
{
    public string nextSceneName; // ���ͩҡ (scene) ���س��ͧ��������Ŵ����ͨ����Ź�

    void Start() {
        // Subscribe ������¡�ѧ��ѹ OnTimelineFinished ������Դ�˵ء�ó쨺���Ź�
        GetComponent<PlayableDirector>().stopped += OnTimelineFinished;
    }

    // ��������Ź쨺
    void OnTimelineFinished(PlayableDirector pd) {
        // ��Ŵ�ҡ�Ѵ�
        SceneManager.LoadScene("main menu and play");
    }
}
