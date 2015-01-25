using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class GeneAudioSource : MonoBehaviour {

	public static readonly string TAG = typeof(GeneAudioSource).Name;

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			audio.Play();
		}
	}
}
