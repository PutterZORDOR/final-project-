using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorlock1 : MonoBehaviour
{
    public GameObject buttonOpenDoor;
    public GameObject keyInventory;
    public GameObject buttonLockDoor;
    public GameObject buttonCloseDoor;



    private bool isReach;
    private bool haskey;
    private bool doorIsopen = false;
    public GameObject doorLockText;
    public GameObject doorText;

    private Animator door;
    private void Start() {
        isReach = false;
        haskey = false;
        doorIsopen=false;

        door = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach") 
        {
            isReach = true;
            doorText.SetActive(true);

        
        if(haskey) 
        {
            buttonOpenDoor.SetActive(true);
        } 
        else 
        {
            buttonLockDoor.SetActive(true);
        }
 
      }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Reach") 
        {
            isReach = false;
            buttonOpenDoor.SetActive(false);
            buttonCloseDoor.SetActive(false);
            buttonLockDoor.SetActive(false);
            doorLockText.SetActive(false);
            doorText.SetActive(false);

        }
    }
    private void Update() {
        if (keyInventory.activeInHierarchy) 
            {
            haskey = true;
        } 
        else 
        {
            haskey = false;
        }
        if (isReach && doorIsopen) 
         {
            buttonCloseDoor.SetActive(true);
        }
        if (isReach && haskey && !doorIsopen)
        {
            buttonOpenDoor.SetActive(true);
        }

        // เพิ่มตรวจสอบการกดปุ่ม "R" เพื่อเปิดหรือปิดประตู
        if (isReach && Input.GetKeyDown(KeyCode.F)) 
            {
            if (doorIsopen) 
                {
                CloseDoor();
            } else 
            {
                if (haskey) 
                    {
                    OpenDoor();
                }
                else 
                {
                    DoorLocked();
                }
            }
        }
    }

    public void OpenDoor() 
    {
        door.SetBool("Open",true);
        door.SetBool("Close", false);
        doorIsopen = true;
    }
    public void CloseDoor() 
    {
        door.SetBool("Open",false);
        door.SetBool("Close", true);
        buttonCloseDoor.SetActive(false );
        doorIsopen = false;
    }
    public void DoorLocked() 
    {
        doorLockText.SetActive(true );
        doorText.SetActive(false);
    }
   
      
}


