using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier_animation : MonoBehaviour {
    public AnimationClip walkClip;
    public Animation anim;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim = GetComponent<Animation>();
            anim.AddClip(walkClip, "demo_combat_run");
            anim.Play("demo_combat_run");
        }
    }
}
