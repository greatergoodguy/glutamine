using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AISpeech : MonoBehaviour {

	public static readonly string TAG = typeof(AISpeech).Name;

	Text textUI;

	void Awake() {
		textUI = transform.FindChild("Canvas/Text").GetComponent<Text>();
	}

	public void SetText(string text) {
		//UtilLogger.Log(TAG, "text: " + text);
		textUI.text = text;
	}
}
