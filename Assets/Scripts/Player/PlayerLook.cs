using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
    //camera rotations
    private float rotX = 0.0f;
    private float rotY = 0.0f;
    //camera sens
    public float xMouseSensitivity = 30.0f;
    public float yMouseSensitivity = 30.0f;
    //camera
    public Transform playerView;


	// Use this for initialization
	void Start () {
        //kill cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        //rotate camera
        rotX -= Input.GetAxis("Mouse Y") * xMouseSensitivity * 0.02f;
        rotY += Input.GetAxis("Mouse X") * yMouseSensitivity * 0.02f;

        //rotate transform object (this)
        this.transform.rotation = Quaternion.Euler(0, rotY, 0);
        playerView.rotation = Quaternion.Euler(rotX, rotY, 0);

        //clamp X rotation
        rotX = Mathf.Clamp(rotX, -90, 90);
        
	}
}
