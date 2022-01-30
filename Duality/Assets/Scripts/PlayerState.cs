using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public static PlayerState Instance {get; private set; }

    public bool isFacingRight;
    public bool isGrounded;
    public bool isJumping;
    public bool isRunning;

    public float currentXPos;

    void Awake () {
        //Initiate singleton
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
        isFacingRight = true;
        isJumping = false;
        isRunning = false;
    }
}
