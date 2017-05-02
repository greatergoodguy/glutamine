using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class AICindysHouse : MonoBehaviour {

	public void Activate() {
		GetComponent<AudioSource>().Play();
	}

}
