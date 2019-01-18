using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {

    public Light light;
    bool white = true;
    bool red = false;
    bool green = false;
    bool blue = false;

    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
        light.color = Color.white;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("tab"))
        {
            print("Tab pressed!");
            if(white)
            {
                light.color = Color.red; // Red
                red = true;
                white = false;
            }
            else if(red)
            {
                light.color = Color.green; // Green
                green = true;
                red = false;
            }
            else if(green)
            {
                light.color = Color.blue; // Blue
                blue = true;
                green = false;
            }
            else if(blue)
            {
                light.color = Color.white; // White
                blue = false;
                white = true;
            }
        }
    }
}
