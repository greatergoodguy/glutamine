using UnityEngine;
using System.Collections;

public class AIBigBunny : MonoBehaviour {

	public static readonly string TAG = typeof(AIBigBunny).Name;

	AudioSource audio;

	void Awake() {
		audio = GetComponent<AudioSource>();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			audio.Play();
		}
	}
}
