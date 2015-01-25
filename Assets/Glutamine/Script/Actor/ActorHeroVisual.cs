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
		bool isLeftArrowDown = Input.GetKey(KeyCode.LeftArrow);
		UtilLogger.Log(TAG, "Update() - isLeftArrowDown, isFacingRight: " + isLeftArrowDown + ", " + isFacingRight);
		if(Input.GetKey(KeyCode.LeftArrow) && isFacingRight) {
			LookLeft();
		}
		if(Input.GetKey(KeyCode.RightArrow) && !isFacingRight) {
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
