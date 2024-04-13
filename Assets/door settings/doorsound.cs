using System.Collections;
using UnityEngine;

public class doorsound : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;
    
    [Header("Animation Names")]
    [SerializeField] private string openAnimationName = "doorsimple";
    [SerializeField] private string closeAnimationName = "DoorClose";

    [Header("Pause Timer")]
    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    [Header("Audio")]
    [SerializeField] private AudioSource doorOpenAudioSource = null;
    [SerializeField] private float openDelay = 0;
    [Space(10)]
    [SerializeField] private AudioSource doorCloseAudioSource = null;
    [SerializeField] private float closeDelay = 0.8f;
    private void Awake() {
        doorAnim = gameObject.GetComponent<Animator>();
    }
    private IEnumerator PauseDoorInteraction() {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }
    public void PlayAnimation() {
    if (!doorOpen && !pauseInteraction) 
        {
            doorAnim.Play(openAnimationName, 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
            doorOpenAudioSource.PlayDelayed(openDelay);
        }
    else if(doorOpen && !pauseInteraction) {

            doorAnim.Play(closeAnimationName, 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
            doorCloseAudioSource.PlayDelayed(closeDelay);
        }

    }
}
