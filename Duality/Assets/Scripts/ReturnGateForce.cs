using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGateForce : MonoBehaviour
{
    [SerializeField] float pushForce = 10f;
    void OnTriggerStay(Collider otherCollider) {
        if(otherCollider.gameObject.CompareTag("Player")) {
            otherCollider.GetComponent<Rigidbody>().AddForce(new Vector3(pushForce,0,0));
        }
    }
}
