using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public AudioSource life;
    public AudioSource death;
        void OnTriggerEnter(Collider ChangeScene)
    {
        if(ChangeScene.gameObject.CompareTag("Player"))
        {
            death.Stop();
            life.Stop();
            Application.LoadLevelAdditive(3);
        }
    }

}
