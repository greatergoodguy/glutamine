using UnityEngine;
using System.Collections;

public class ActorHeroVisual : Actor_Base {

	public static readonly string TAG = typeof(ActorHeroVisual).Name;

	public float rotationSmoothing = 25.0f;
	
	private Vector3 targetAngles;

	bool isFacingRight = true;

	void Start () {
	
	}

	void Update () {
		bool getKey_Left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
		if(getKey_Left && isFacingRight) {
			LookLeft();
		}

		bool getKey_Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
		if(getKey_Right && !isFacingRight) {
			LookRight();
		}
	}

	void LookLeft() {
		UtilLogger.Log(TAG, "LookLeft()");
		isFacingRight = false;
		transform.localScale = new Vector3(-1, 1, 1);
//		targetAngles = transform.eulerAngles + 180f * Vector3.up;
//		UtilLogger.Log(TAG, "transform.eulerAngles, targetAngles: " + transform.eulerAngles + ", " + targetAngles);
//		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, rotationSmoothing * Time.deltaTime);
	}

	void LookRight() {
		UtilLogger.Log(TAG, "LookRight()");
		isFacingRight = true;
		transform.localScale = new Vector3(1, 1, 1);
//		targetAngles = transform.eulerAngles + 180f * Vector3.up;
//		UtilLogger.Log(TAG, "transform.eulerAngles, targetAngles: " + transform.eulerAngles + ", " + targetAngles);
//		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, rotationSmoothing * Time.deltaTime);
	}
}
