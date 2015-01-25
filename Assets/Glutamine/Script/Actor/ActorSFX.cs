using UnityEngine;
using System.Collections;

public class ActorSFX : Actor_Base {

	AudioSource heroWalking;
	public AudioSource HeroWalking {
		get {
			return heroWalking;
		}

	}

	AudioSource heroJump;
	public AudioSource HeroJump {
		get {
			return heroJump;
		}
	}

	AudioSource startMenuButton;
	public AudioSource StartMenuButton {
		get {
			return startMenuButton;
		}
		
	}

	void Awake() {
		heroWalking = transform.FindChild("Hero Walking").GetComponent<AudioSource>();
		heroJump = transform.FindChild("Hero Jump").GetComponent<AudioSource>();
		startMenuButton = transform.FindChild("Start Menu Button").GetComponent<AudioSource>();
	}

	void Start() {
		ActorHero hero = God.ActorHero;
		hero.AddChildToCamera(heroWalking);
		hero.AddChildToCamera(heroJump);
		hero.AddChildToCamera(startMenuButton);
	}

}
