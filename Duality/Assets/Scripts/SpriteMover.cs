using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    [SerializeField] float jumpAngle = 20f;
    [SerializeField] float tipAngle = 10f;
    private bool isJumpAngled;
    private enum CatAngle {
        level,
        tippedForward,
        levelFromForward,
        tippedBackwards,
    };

    private CatAngle currentAngle;

    void Awake() {
        isJumpAngled = false;
        currentAngle = CatAngle.level;
    }

    void Update()
    {
        if(PlayerState.Instance.isJumping) {
            // if(PlayerState.Instance.isFacingRight) {
                gameObject.transform.rotation *= Quaternion.Euler(0,0,20);
                PlayerState.Instance.isJumping = false;
                isJumpAngled = true;
            // } else {
            //     gameObject.transform.rotation *= Quaternion.Euler(0,0,-20);
            //     PlayerState.Instance.isJumping = false;
            //     isJumpAngled = true;
            // }
            
        }
        
        if(PlayerState.Instance.isGrounded && isJumpAngled) {
            // if(PlayerState.Instance.isFacingRight){
                gameObject.transform.rotation*= Quaternion.Euler(0,0,-20);
                isJumpAngled = false;
            // } else {
            //     gameObject.transform.rotation*= Quaternion.Euler(0,0,20);
            //     isJumpAngled = false;
            // }
        }

        if(PlayerState.Instance.isRunning && !isJumpAngled) {
            if(currentAngle == CatAngle.level){
                gameObject.transform.rotation *= Quaternion.Euler(0,0,-tipAngle);
                currentAngle = CatAngle.tippedForward;
            } else if(currentAngle == CatAngle.tippedForward) {
                gameObject.transform.rotation *= Quaternion.Euler(0,0,tipAngle);
                currentAngle = CatAngle.levelFromForward;
            } else if(currentAngle == CatAngle.levelFromForward) {
                gameObject.transform.rotation *= Quaternion.Euler(0,0,tipAngle);
                currentAngle = CatAngle.tippedBackwards;
            } else if(currentAngle == CatAngle.tippedBackwards) {
                gameObject.transform.rotation *= Quaternion.Euler(0,0,-tipAngle);
                currentAngle = CatAngle.level;
            }
        }
    }
}
