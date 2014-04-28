using UnityEngine;
using System.Collections;

public class Wheraldo : MonoBehaviour {

	public string nextScene;
	public AudioClip winningSound;
	public GameObject winningSplash;


	void OnTriggerEnter(Collider collider){
		Debug.Log("Trigger");
		if(collider.gameObject.tag == "Player")
			StartCoroutine(OnWin());
	}

	public IEnumerator OnWin () {
		Debug.Log("WINNING");
		audio.PlayOneShot(winningSound);
		winningSplash.SetActive(true);

		yield return new WaitForSeconds(3);
		if (!nextScene.Equals("")) {
			Application.LoadLevel(nextScene);
		}
	}

}