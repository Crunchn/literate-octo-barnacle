using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
    //camera rotations
    private float rotX = 0.0f;
    private float rotY = 0.0f;
    public float xMouseSensitivity = 30.0f;
    public float yMouseSensitivity = 30.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //rotate camera
        rotX -= Input.GetAxis("Mouse Y") * xMouseSensitivity * 0.02f;
        rotY += Input.GetAxis("Mouse X") * yMouseSensitivity * 0.02f;

        //rotate transform object (this)
        this.transform.rotation = Quaternion.Euler(0, rotY, 0);
        this.transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        
	}
}
