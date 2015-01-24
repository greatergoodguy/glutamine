using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ActorPauseMenu : Actor_Base {

	public event Action actionResume = () => {};
	public event Action actionQuit = () => {};

	void Start() {
		transform.FindChild("Canvas").gameObject.SetActive(true);
	}

	public void ActionResume() {
		actionResume();
	}

	public void ActionQuit() {
		actionQuit();
	}
}
