using UnityEngine;
using System.Collections;

public class StuckInSphere : MonoBehaviour {

	public float gravityStrength = 10f;
	public float sphereRadius = 20f;
	public GameObject center;
	public float bounceRatio = 0.5f;

	void FixedUpdate () {
		var centerPosition = center.transform.position;
		if(Vector3.Distance(centerPosition,  transform.position) > sphereRadius)
		{
			rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, (centerPosition - transform.position).normalized) * bounceRatio;
			//Vector3 f = new Vector3(Random.value, Random.value, Random.value) * 20;
			//rigidbody.AddForce( f);
		}
	}
}
