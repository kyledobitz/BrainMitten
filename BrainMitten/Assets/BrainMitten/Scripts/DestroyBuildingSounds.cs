using UnityEngine;
using System.Collections;

public class DestroyBuildingSounds : MonoBehaviour {

	public AudioClip[] destructionSounds;

	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Collision");
		if (collision.gameObject.tag == "Destructible")
			Debug.Log ("Destructible");
			audio.PlayOneShot (destructionSounds [Random.Range (0, destructionSounds.Length)]);
	}
}
