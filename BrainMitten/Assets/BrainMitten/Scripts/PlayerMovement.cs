using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 5f;
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		Vector3 velocity = (new Vector3 (h,0,v)).normalized*maxSpeed;
		
		rigidbody.velocity = velocity;
	}
}
