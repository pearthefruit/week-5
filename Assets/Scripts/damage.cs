using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {

	public float health = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//in update cuz want to check every frame that this happens
		if ( health <= 0f ) {
			Destroy ( gameObject );
			//destroy will delete game object from game
		}
	}
}
