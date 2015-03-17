using UnityEngine;
using System.Collections;

public class trapDamage : MonoBehaviour {
	Collider thingCurrentlyInside;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (thingCurrentlyInside != null ) {
			//if there is a thing ucrrently inside this trigger...
			//then damage it
			thingCurrentlyInside.GetComponent<damage>().health -= Time.deltaTime * .1f;
			//finds the object that is "damageable" and subtracts health by 10 per second
		}
	}

	//Unity automatically calls this function when an object with a rigidbody enters this object's trigger collider
	//AND it will tell you WHAT entered it
	void OnTriggerEnter ( Collider Activator ) {
		thingCurrentlyInside = Activator; //want to remember the thing that entered the trigger
	}
	void OnTriggerExit ( Collider Exiter ) {
		//called when something exits the volume
		// "null" means nothing, empty, absence of data
		thingCurrentlyInside = null;
	}
}
