using UnityEngine;
using System.Collections;

public class AIBalloon : MonoBehaviour {
	
	[Range(0, 5)] public float floatRate = 0.6f;
	
	void Update () {
		Vector3 movement = new Vector3 (0, floatRate, 0) * Time.deltaTime;	
		transform.Translate(movement);
	}
}
