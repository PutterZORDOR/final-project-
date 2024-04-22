using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guncontroller : MonoBehaviour
{
    public Projector gunscipt;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, gunContanier, fpscam;

    public float PickUpRaange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    private void Update() {
        Vector3 distanceToPlayer = transform.position - player.position;
        if (!equipped && distanceToPlayer.magnitude <= PickUpRaange && Input.GetKeyDown(KeyCode.E) && !slotFull)Pickup();

        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();
    }

        private void Pickup() {
            equipped = true;
            slotFull = true;

        rb.isKinematic = true;
        coll.isTrigger = true;

        gunscipt.enabled = true;
        }
    private void Drop() {
        equipped =false;
        slotFull = false;

        rb.isKinematic = false;
        coll.isTrigger = false;

        gunscipt.enabled = false;
    }
}

