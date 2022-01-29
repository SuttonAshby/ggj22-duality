using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryTrigger : MonoBehaviour
{

    Collider boundaryCollider;

    [SerializeField] bool isUpperToLowerTrigger = true;

    void Awake () {
        boundaryCollider = GetComponent<Collider>();
    }

    void OnTriggerExit(Collider otherCollider) {
        if(otherCollider.gameObject.CompareTag("Player")) {
            if(isUpperToLowerTrigger) {
                WorldState.Instance.isInUpperWorld = false;
            } else {
                WorldState.Instance.isInUpperWorld = true;
            }
        }
    }

    void Update() {
        if(WorldState.Instance.isInUpperWorld) {
            if(isUpperToLowerTrigger) {
                boundaryCollider.isTrigger = true;
            } else {
                boundaryCollider.isTrigger = false;
            }
        } else {
            if(isUpperToLowerTrigger) {
                boundaryCollider.isTrigger = false;
            } else {
                boundaryCollider.isTrigger = true;
            }
        }
    }
}
