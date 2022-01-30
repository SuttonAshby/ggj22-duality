using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] float pushForce = 20f;
    void OnTriggerStay(Collider otherCollider) {
        if(otherCollider.gameObject.CompareTag("Player")) {
            otherCollider.GetComponent<Rigidbody>().AddForce(new Vector3(0,pushForce,0));
        }
    }
}
