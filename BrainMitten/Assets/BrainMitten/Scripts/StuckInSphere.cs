using UnityEngine;
using System.Collections;

public class StuckInSphere : MonoBehaviour {

	public float gravityStrength = 10f;
	public float sphereRadius = 20f;
	public GameObject center;
	public float bounceRatio = 0.9f;

	void FixedUpdate () {
		var centerPosition = center.transform.position;
		var upVector = centerPosition - transform.position;
		if(upVector.magnitude > sphereRadius)
		{
			rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, (centerPosition - transform.position).normalized) * 0.9f;
			//Vector3 f = new Vector3(Random.value, Random.value, Random.value) * 20;
			//rigidbody.AddForce( f);
		}
		rigidbody.AddForce( - upVector.normalized * gravityStrength );
	}
}
