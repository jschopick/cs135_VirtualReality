using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTimerScript : MonoBehaviour {
    
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public static int lightNum;

    private float timer = 0.0f;
    private float waitTime = 3.0f;
    private int currNum = 0;
    private int lastNum = 0;


    // Use this for initialization
    void Start()
    {
        light1.color = Color.black;
        light2.color = Color.black;
        light3.color = Color.black;
        light4.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime || Trigger1.triggered || Trigger2.triggered || Trigger3.triggered || Trigger4.triggered)
        {
            // Remove the recorded 3 seconds.
            timer = timer - waitTime;
            Trigger1.triggered = false;
            Trigger2.triggered = false;
            Trigger3.triggered = false;
            Trigger4.triggered = false;

            // Ensures we do not get the same number twice
            do
            {
                currNum = Random.Range(1, 4);
            } while (currNum == lastNum);
            lastNum = currNum;
            
            if(currNum == 1)
            {
                lightNum = 1;
                light1.color = Color.white; // On
                light2.color = Color.black; // Off
                light3.color = Color.black; // Off
                light4.color = Color.black; // Off
            }
            else if (currNum == 2)
            {
                lightNum = 2;
                light1.color = Color.black; // Off
                light2.color = Color.white; // On
                light3.color = Color.black; // Off
                light4.color = Color.black; // Off
            }
            else if (currNum == 3)
            {
                lightNum = 3;
                light1.color = Color.black; // Off
                light2.color = Color.black; // Off
                light3.color = Color.white; // On
                light4.color = Color.black; // Off
            }
            else if (currNum == 4)
            {
                lightNum = 4;
                light1.color = Color.black; // Off
                light2.color = Color.black; // Off
                light3.color = Color.black; // Off
                light4.color = Color.white; // On
            }
        }
    }
}
