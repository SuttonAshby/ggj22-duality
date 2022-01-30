using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public static GameManager Instance {get; private set;}
    private void Awake () {
        //Initiate singleton
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
 
        }
    public bool isPlaying = false;
    public void ExitNow() {
        Application.Quit();
    }
    //Timer
    public float playedTime;
    public Text timeDisplay;
    public void Start() {
        playedTime = 0f;
    }

    public void Update(){

        if(isPlaying){
            playedTime += Time.deltaTime;
            timeDisplay.text = "Time: " + Mathf.RoundToInt(playedTime);
//Escape

   
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            Application.Quit();
        // }

    }
    
}}
} 