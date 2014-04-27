using UnityEngine;
using System.Collections;

public class SplashScene : MonoBehaviour {
	public string nextScene = "Gojira Scene";
	public float delayTime = 2.0f;
	private float startTime;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	void Update () {
		if(Time.time - startTime < delayTime) return;
		if(Input.anyKeyDown)
			Application.LoadLevel (nextScene);
	}
}
