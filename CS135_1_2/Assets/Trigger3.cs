﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour {

    public static bool triggered = false;

    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (LightTimerScript.lightNum == 3)
        {
            if(OVRInput.Get(OVRInput.Button.One)) // Button A was pressed
            {
                triggered = true;
                ScoreScript.scoreNum++;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        
    }
}
