using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void OnDestroy()
    {
     GetComponent<AudioSource>().Stop();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
