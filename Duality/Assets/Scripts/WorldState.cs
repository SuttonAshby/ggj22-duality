using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldState : MonoBehaviour
{
    public static WorldState Instance {get; private set; }
    public bool isInUpperWorld;

    void Awake () {
        //Initiate singleton
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
        isInUpperWorld = true;
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.P)) {
            isInUpperWorld = true;
        }

        if(Input.GetKeyDown(KeyCode.L)) {
            isInUpperWorld = false;
        }
    }
}
