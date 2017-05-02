using UnityEngine;
using System.Collections;

public class ActorWorld : Actor_Base {

	Vector3 vecStartPos;

	void Awake() {
		vecStartPos = transform.FindChild("Start Position").position;
	}

	public void Reset() {
		God.ActorHero.transform.position = vecStartPos;
	}

	void Update() {
		if (ActorHero.I.transform.position.y < -100.0f) {
			Reset();
		}
	}

}
