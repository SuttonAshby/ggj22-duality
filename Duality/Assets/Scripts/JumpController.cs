using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{

    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private bool shouldJump;
    private Rigidbody rigidBody;

    void Awake() {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if(shouldJump == false && PlayerState.Instance.isGrounded) {
        shouldJump = Input.GetAxis("Jump") != 0;
        }
        //TODO maybe add sprint function
    }

    void FixedUpdate() {  
        //TODO check is grounded for jump
        if(shouldJump && PlayerState.Instance.isGrounded) {
            GetComponent<AudioSource>().Play();
            rigidBody.AddForce(jumpForce * Vector3.up);
            shouldJump = false;
            PlayerState.Instance.isJumping = true;
        }
    }
}
