using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 5f;
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		Vector3 direction = (new Vector3 (h, 0, v)).normalized;
		Vector3 velocity = direction*maxSpeed;

		if(direction.magnitude > 0)
			rigidbody.transform.forward = direction;
		rigidbody.velocity = velocity;
	}
}
