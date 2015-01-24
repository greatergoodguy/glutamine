using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ActorMainMenu : Actor_Base {

	public event Action actionPlay = () => {};

	void Start() {
		transform.FindChild("Canvas").gameObject.SetActive(true);
	}

	public void ActionPlay() {
		actionPlay();
	}

}
