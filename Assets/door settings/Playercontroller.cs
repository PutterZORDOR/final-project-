using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Playercontroller : MonoBehaviour
{

    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask LayerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private Doorcontroller raycasteObj;
    [SerializeField] private KeyCode openDoorKey = KeyCode.E;
    [SerializeField] private Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    private void Update() 
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | LayerMaskInteract.value;
        if(Physics.Raycast(transform.position, fwd, out hit , rayLength, mask)) 
            {
            if (hit.collider.CompareTag(interactableTag)) 
            {
                if (!doOnce) 
                {
                    raycasteObj = hit.collider.gameObject.GetComponent<Doorcontroller>();
                    CrosshairChange(true);
                }
                    
                    isCrosshairActive = true;
                    doOnce = true;
                    
                    if(Input.GetKeyDown(openDoorKey)) 
                    {
                        raycasteObj.PlayAnimation();
                    }

                
            }
        }
        else 
        {
            if (isCrosshairActive) 
            {
                CrosshairChange(false);
                doOnce= false;
            }
        }
    }
    void CrosshairChange(bool on) 
        {
        if(on && !doOnce) 
            {
            crosshair.color = Color.red;
        } 
        else 
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}

      


