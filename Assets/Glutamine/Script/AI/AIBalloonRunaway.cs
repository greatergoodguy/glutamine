using UnityEngine;
using System.Collections;

public class AIBalloonRunaway : MonoBehaviour {

	public void Activate() {
		God.ActorSFX.StartMenuButton.Play();
		God.ActorSFX.Failure.Play();
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
