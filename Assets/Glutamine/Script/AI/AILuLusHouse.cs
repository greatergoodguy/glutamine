using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class AILuLusHouse : MonoBehaviour {

	public void Activate() {
		GetComponent<AudioSource>().Play();
	}

}
