using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
public AudioSource life;
public AudioSource death;

         void Start() 
     {
         if (WorldState.Instance.isInUpperWorld)
         life.Play();    
     }
     
     void Update () 
     {
         if (!WorldState.Instance.isInUpperWorld)
         {
             if (life.isPlaying)
             {
                 life.Stop();
 
                 death.Play();
         }
     }
         if (WorldState.Instance.isInUpperWorld)
         {
             if (death.isPlaying)
             {
                 death.Stop();
 
                 life.Play();
         }
     }
 }
}