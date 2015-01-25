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

}
