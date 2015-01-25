using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using System;
using System.Collections;

public class GeneTrigger : MonoBehaviour {

	public static readonly string TAG = typeof(GeneTrigger).Name;


	[Serializable]
	public class ButtonClickedEvent : UnityEvent { }
	
	// Event delegates triggered on click.
	[FormerlySerializedAs("on Trigger")]
	[SerializeField]
	private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
	
	void OnTriggerEnter(Collider other) {
		UtilLogger.Log(TAG, "OnTriggerEnter()");
		if(other.tag == "Player") {
			m_OnClick.Invoke();
		}
	}
}