using UnityEngine;
using System.Collections;

public class AIAppleTrigger : MonoBehaviour {

	static Object oCloner;
	public void Activate() {
		if(oCloner == null) {
			oCloner = Resources.Load("Apple", typeof(GameObject));}

		GameObject go = GameObject.Instantiate(oCloner) as GameObject;
		go.transform.position = transform.position;
		go.GetComponent<Rigidbody>().AddForce(new Vector3(0.5f, 1.0f, 0));

		go.AddComponent<GeneSuicide>();


	}
}
