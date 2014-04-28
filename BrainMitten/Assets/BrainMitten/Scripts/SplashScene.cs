using UnityEngine;
using System.Collections;

public class SplashScene : MonoBehaviour {
	public string nextScene = "Gojira Scene";
	public float inputDelayTime = 2.0f;
	public float imageDelayTime = 1.0f;

	private float startTime;
	
	public GameObject[] splashes;
	private int currentSplash = 0;



	// Use this for initialization
	void Start () {
		foreach(GameObject image in splashes){
			image.SetActive(false);
		}
		splashes[currentSplash].SetActive(true);
		startTime = Time.time;

		StartCoroutine(PlaySplashImages());
	}
	
	void Update () {
		if(Time.time - startTime < inputDelayTime) return;
		if(Input.anyKeyDown)
			Application.LoadLevel (nextScene);
	}

	IEnumerator PlaySplashImages(){
		for(int i = currentSplash; i < splashes.Length-1; i++){
			yield return new WaitForSeconds(imageDelayTime);

			splashes[currentSplash].SetActive(false);
			currentSplash++;
			splashes[currentSplash].SetActive(true);
		}
	}
}
