using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y != 0) {
            gameObject.transform.position += new Vector3(0, -gameObject.transform.position.y, 0);
        }
    }
}

