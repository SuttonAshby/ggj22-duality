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
    // lastYPos = gameObject.transform.position.y;
  }
 
  // private float lastYPos;
  // void Update() {
  //   float newYPos = gameObject.transform.position.y;
  //   if(lastYPos == newYPos) {
  //     PlayerState.Instance.isGrounded = true;
  //   }
  //   lastYPos = newYPos;
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
      }
      
      //TODO check is grounded for jump
      // if(shouldJump) {
      //   rigidBody.AddForce(jumpForce * Vector3.up);
      //   shouldJump = false;
      // }

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