using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

  [SerializeField] private float moveForceHorizontal = 20f;
  [SerializeField] private float moveForceVertical = 20f;
  [SerializeField] private float maxVelocity = 1f;

  private Rigidbody rigidBody;

  void Awake() {
    rigidBody = GetComponent<Rigidbody>();
  }
 
  // void Update() {
  //   PlayerState.Instance.currentXPos = gameObject.transform.position.x;
  // }
  
  void FixedUpdate() {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    if(WorldState.Instance.isInUpperWorld) {
      if(rigidBody.velocity.magnitude >= maxVelocity) {
        return;
      }
      if(horizontal != 0) {
        rigidBody.AddForce(moveForceHorizontal * Vector3.right * horizontal);
        PlayerState.Instance.isRunning = true;
      } else {
        PlayerState.Instance.isRunning = false;
      }
      
      if(horizontal > 0) {
        PlayerState.Instance.isFacingRight = true;
      }
      if(horizontal < 0) {
        PlayerState.Instance.isFacingRight = false;
      } 

    } else {
      if(vertical != 0) {
        rigidBody.AddForce(moveForceVertical * Vector3.up * vertical);
      }
    } 
  }
}