using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    private Renderer renderer;
    [SerializeField] bool isVisible;


  void Awake() {
    renderer = GetComponent<Renderer>();
    isVisible = false;
  } 

  void OnTriggerEnter(Collider otherCollider) {
      if(otherCollider.gameObject.CompareTag("Player")) {
          isVisible = true;
      }
  }

    void OnTriggerExit(Collider otherCollider) {
      if(otherCollider.gameObject.CompareTag("Player")) {
          isVisible = false;
      }
  }

    // Update is called once per frame
    void Update()
    {
        if(!WorldState.Instance.isInUpperWorld || isVisible) {
            renderer.enabled = true;
        } else {
            renderer.enabled = false;
        }
    }
}
