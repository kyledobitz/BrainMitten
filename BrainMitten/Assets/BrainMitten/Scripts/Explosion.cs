using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	
	public float radius = 5.0F;
	public float power = 100.0F;
	
	// Update is called once per frame
	void Update () {
		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders) {
			if (hit && hit.rigidbody)
				hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);
			
		}
	
	}
}
