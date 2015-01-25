using UnityEngine;
using System.Collections;

public class GeneFollowHero : MonoBehaviour {

	private static readonly float TOTAL_DURATION = 10.0f;

	Transform leader;
	public float speed = 5;

	float elapsedTime = 0;
	bool isFinished = false;

	void Start() {
		leader = God.ActorHero.transform;
	}

	void  Update() {
		transform.LookAt(leader, Vector3.up);

		Vector3 translateVector = speed * Vector3.forward * Time.deltaTime;
		transform.Translate(translateVector);
	}
}
