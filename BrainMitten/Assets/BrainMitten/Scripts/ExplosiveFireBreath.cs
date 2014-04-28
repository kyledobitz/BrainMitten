using UnityEngine;
using System.Collections;

public class ExplosiveFireBreath : MonoBehaviour {

	public float cooldownDelay = 1f;
	public float nextFireTime = 0f;
	public float breathForce = 20f;
	public Collider breathSpace;
	public GameObject fire;
	public AudioClip fireAudio;

	// Update is called once per frame
	void Update () {
		if (Time.time < nextFireTime)
			return;
		if (!Input.GetButtonDown ("Fire1"))
			return;
		nextFireTime = Time.time + cooldownDelay;
		fire.particleSystem.Play();
		Debug.Log ("Explosion");
		audio.PlayOneShot(fireAudio);
		Vector3 explosionPos = breathSpace.transform.position;
		float radius = Vector3.Distance (transform.position, explosionPos);
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders) {
			if (
				hit && 
				hit.rigidbody && 
			    hit.tag != "Player" && 
			    hit.bounds.Intersects(breathSpace.bounds)
		    )
				hit.rigidbody.AddExplosionForce(breathForce, transform.position, 2*radius, 3.0F);
			
		}
	}
}
