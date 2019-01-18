using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    GameObject textObject;
    public Text ourComponent;
    public static int scoreNum = 0;

	// Use this for initialization
	void Start () {
        textObject = GameObject.Find("Score");
        ourComponent = textObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        ourComponent.text = "Score:  " + scoreNum.ToString();
    }
}
