using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {
		
	public string nextScene = "Credits Scene";
	
	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.tag == "Player")
			Application.LoadLevel (nextScene);
		
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Player")
			Application.LoadLevel (nextScene);
		
	}
}
