using UnityEngine;
using System.Collections;

public class LightInputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		rigidbody2D.velocity = (new Vector2(h, v)).normalized * 5.0f;
	}
}
