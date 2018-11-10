using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafeAnimController : MonoBehaviour {

	Animator animator;
	Rigidbody rb;
	public float animSpeed = 1.5f;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		animator.speed = animSpeed;

		animator.SetFloat("Forward", transform.InverseTransformDirection(rb.velocity).z);
		animator.SetFloat("Right", transform.InverseTransformDirection(rb.velocity).x);
		//print(rb.velocity.x);


	}
}
