using UnityEngine;
using System.Collections;

public class ActorSFX : Actor_Base {

	AudioSource heroWalking;
	public AudioSource HeroWalking {
		get {
			if(heroWalking == null) {
				heroWalking = transform.FindChild("Hero Walking").GetComponent<AudioSource>();
			}
			return heroWalking;
		}

	}

	void Start() {
		ActorHero hero = God.ActorHero;
	}

}
