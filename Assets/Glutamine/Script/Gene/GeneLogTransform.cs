using UnityEngine;
using System.Collections;

public class GeneLogTransform : MonoBehaviour {
	
	public static readonly string TAG = typeof(GeneLogTransform).Name;
	
	void Start () {
		
	}
	
	void Update () {
		UtilLogger.Log(TAG, "Update() - (pos, rot, scale): (" + transform.position + ", " + transform.rotation + ", " + transform.localScale + ")");
	}
}