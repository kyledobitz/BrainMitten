using UnityEngine;
using System.Collections;

public class WinningLightZoneScript : MonoBehaviour {

	public string nextScene;
	public AudioClip winningSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			Debug.Log("Danger Zone!");
			StartCoroutine(OnWin());
		}
	}

	private IEnumerator OnWin () {
		audio.PlayOneShot(winningSound);
		yield return new WaitForSeconds(3);
		if (!nextScene.Equals("")) {
			Application.LoadLevel(nextScene);
		}
	}
}
