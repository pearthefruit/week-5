using UnityEngine;
using System.Collections;

public class PhysicsControl : MonoBehaviour {

	public float speed = 30f;
	public float turnSpeed = 5f;



	// Use this for initialization
	Rigidbody rbody;

	void Start () {
		// "caching" a reference to the rigidbody
		rbody = GetComponent<Rigidbody>();

	}
	
	// Update is called on a fixed interval / every physics frame
	// Use FixedUpdate for doing anything with physics such as applying forward force when holding w

	void FixedUpdate () {
		// INPUT AXES: a virtual joystick that returns a float from -1 to 1
		rbody.AddForce ( transform.forward * speed * Input.GetAxis ("Vertical") );
		//comment out sideways movement
		// rbody.AddForce ( transform.right * speed * Input.GetAxis ("Horizontal") );

		//TURNING
		//GetAxis gives a number between -1 and 1
		 transform.Rotate ( 0f, Input.GetAxis ("Horizontal") * turnSpeed, 0f );

	}
}
