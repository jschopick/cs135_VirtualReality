using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour {

    public GameObject ball;
    public Rigidbody rigidBody;

    void OnTriggerEnter(Collider other) {
        rigidBody = ball.GetComponent<Rigidbody>();
        rigidBody.useGravity = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
