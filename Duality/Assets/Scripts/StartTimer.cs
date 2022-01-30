using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GameManager.Instance.playedTime = 0f;
      GameManager.Instance.isPlaying = true;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
