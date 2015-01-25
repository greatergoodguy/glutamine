using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using System;
using System.Collections;

public class GeneActionBubble : MonoBehaviour {

	public static readonly string TAG = typeof(GeneActionBubble).Name;
	
	GameObject goSpeech;

	[Serializable]
	public class ButtonClickedEvent : UnityEvent { }
	
	// Event delegates triggered on click.
	[FormerlySerializedAs("on Z pressed")]
	[SerializeField]
	private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
	
	void Update() {
		if(Input.GetKeyDown(KeyCode.Z)) {
			if(goSpeech != null) {
				Destroy(goSpeech);
				m_OnClick.Invoke();
			}
		}
	}
	
	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			goSpeech = God.CreateSpeechActionBubble(transform);
		}
	}
	
	void OnTriggerExit(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			Destroy(goSpeech);
		}
	}
}