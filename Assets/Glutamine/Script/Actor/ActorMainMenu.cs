using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ActorMainMenu : Actor_Base {

	public event Action actionPlay = () => {};

	public void ActionPlay() {
		actionPlay();
	}

}
