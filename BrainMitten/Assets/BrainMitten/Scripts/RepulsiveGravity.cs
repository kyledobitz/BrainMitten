using UnityEngine;
using System.Collections;

public class RepulsiveGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider collider){
		Debug.Log ("On Trigger Stay");
		collider.gameObject.rigidbody.AddForce (Vector3.forward * 10f);
	}

	void OnTriggerExit(Collider collider){
		collider.gameObject.rigidbody.velocity = collider.gameObject.rigidbody.velocity * -0.5f;
	}
}
