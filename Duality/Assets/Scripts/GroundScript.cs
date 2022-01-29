using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{


    void OnTriggerStay(Collider otherCollider) {
        if(otherCollider.gameObject.CompareTag("Player")) {
            PlayerState.Instance.isGrounded = true;
        }
    }

    void OnTriggerExit(Collider otherCollider) {
        if(otherCollider.gameObject.CompareTag("Player")) {
            PlayerState.Instance.isGrounded = false;
        }
    }
}
