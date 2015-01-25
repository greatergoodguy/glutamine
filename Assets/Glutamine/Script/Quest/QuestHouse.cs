using UnityEngine;
using System.Collections;

public class QuestHouse : MonoBehaviour {

	GameObject goBoy;
	GameObject goHouse;

	void Start() {
		goBoy = transform.FindChild("boywithHouse").gameObject;
		goHouse = transform.FindChild("HouseForGlutamine").gameObject;
	}
	
	public void Activate() {
		goHouse.rigidbody.AddRelativeTorque(50000 * Vector3.forward);

		GeneSpeech geneSpeech = goBoy.GetComponent<GeneSpeech>();
		geneSpeech.text = "WHY DID YOU DO THAT!!!";
	}
	
}

