using UnityEngine;
using System.Collections;

public class AILuLu : MonoBehaviour {

	public static readonly string TAG = typeof(AILuLu).Name;

	GameObject goSpeech;

	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			GetComponent<AudioSource>().Play();
			
			goSpeech = God.CreateSpeechBubble("text", transform);
		}
	}
	
	void OnTriggerExit(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			Destroy(goSpeech);
		}
	}
}
