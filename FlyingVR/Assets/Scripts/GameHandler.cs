﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    private float pause;
    public bool isPauseActive;
    public float timeToStart;
    public bool isEnableToMove;
    public Text text;
    public GameObject panel;
	string message = "¡Buena Suerte!";
    // Use this for initialization
    void Start () {
        pause = 1;
        isEnableToMove = false;
        
    }
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = pause;

        if (timeToStart <= 0)
        {
            isEnableToMove = true;
            text.text = message;
        }
        else {
            timeToStart -= Time.deltaTime;
            text.text = ((int)timeToStart).ToString();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pause.Equals(0))
            {
                GC.Collect();
                pause = 1;
            }
            else
            {
                pause = 0;
            }
        }
    }
    void initGame() {
        panel.SetActive(false);

    }
}
