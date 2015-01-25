using UnityEngine;
using System.Collections;

public class GeneSpeech : MonoBehaviour {

	public enum Size {
		Small,
		Medium,
		Large
	}

	public static readonly string TAG = typeof(GeneSpeech).Name;

	public string text;

	GameObject goSpeech;

	public Size size = Size.Small;
	
	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			if(text == null) {
				text = "";}

			switch(size) {
			case Size.Small:
				goSpeech = God.CreateSpeechBubbleSmall(text, transform);
				break;
			case Size.Medium:
				goSpeech = God.CreateSpeechBubbleMedium(text, transform);
				break;
			case Size.Large:
				goSpeech = God.CreateSpeechBubbleLarge(text, transform);
				break;
			}
		}
	}
	
	void OnTriggerExit(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			Destroy(goSpeech);
		}
	}
}