using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    void gravityDown() {
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }

    void gravityBack() {
        Physics.gravity = new Vector3(-9.8f, 0, 0);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.P)) {
            gravityDown();
        }

        if(Input.GetKeyDown(KeyCode.L)) {
            gravityBack();
        }

        if(WorldState.Instance.isInUpperWorld){
            gravityDown();
        } else {
            gravityBack();
        }

  }

}
