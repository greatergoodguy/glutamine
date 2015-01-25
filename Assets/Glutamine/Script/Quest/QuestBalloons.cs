using UnityEngine;
using System.Collections;

public class QuestBalloons : MonoBehaviour {

	bool isFirstTime = true;

	GameObject goBalloonRunaway;

	void Awake() {
		goBalloonRunaway = transform.FindChild("Balloon Runaway").gameObject;
	}

	public void Activate() {
		if(!isFirstTime) {
			return;}

		isFirstTime = false;

		goBalloonRunaway.AddComponent<AIBalloon>();
		goBalloonRunaway.AddComponent<GeneSuicide>();
	}
}
