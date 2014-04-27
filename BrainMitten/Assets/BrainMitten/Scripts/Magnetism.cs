using UnityEngine;
using System.Collections;

public class Magnetism : MonoBehaviour {

	public float magneticForce = 20f;
	public float cooldownDelay = 1f;
	public float nextFireTime = 0f;
	public float grabForce = 1000f;
	public Collider magneticSpace;

	void Update(){
		if (Time.time < nextFireTime)
			return;
		if (!Input.GetButtonDown ("Fire1"))
			return;

		nextFireTime = Time.time + cooldownDelay;

		var magneticObjects = GameObject.FindGameObjectsWithTag("Magnetic");
		foreach (GameObject magneticObject in magneticObjects) {
			if (
				magneticObject && 
				magneticObject.rigidbody && 
				magneticObject.collider &&
				magneticObject.collider.bounds.Intersects(magneticSpace.bounds)
			){
				Debug.Log("GRABBED");
				magneticObject.rigidbody.AddExplosionForce(
					grabForce,
					magneticObject.transform.position + Vector3.down,
					0);
				magneticObject.tag = "Untagged";
			}
			
		}
	}

	void OnTriggerStay (Collider collider) {
		if (collider.tag != "Magnetic")
			return;
		collider.rigidbody.AddForce(Vector3.up * magneticForce);
	}
}
