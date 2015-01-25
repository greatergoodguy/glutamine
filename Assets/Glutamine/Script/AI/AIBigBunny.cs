using UnityEngine;
using System.Collections;

public class AIBigBunny : MonoBehaviour {

	public static readonly string TAG = typeof(AIBigBunny).Name;

	AudioSource audio;

	Object oSpeechCloner;
	GameObject goSpeech;

	void Awake() {
		audio = GetComponent<AudioSource>();
	}

	void Start () {

		oSpeechCloner = Resources.Load("Speech", typeof(GameObject));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			audio.Play();

			goSpeech = GameObject.Instantiate(oSpeechCloner) as GameObject;
			goSpeech.transform.parent = transform;
		}
	}

	void OnTriggerExit(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			Destroy(goSpeech);
		}
	}
}
