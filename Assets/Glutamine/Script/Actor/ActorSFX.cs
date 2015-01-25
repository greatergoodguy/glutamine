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

	AudioSource success;
	public AudioSource Success {
		get {
			return success;
		}
	}
	
	AudioSource failure;
	public AudioSource Failure {
		get {
			return failure;
		}
		
	}

	void Awake() {
		heroWalking = transform.FindChild("Hero Walking").GetComponent<AudioSource>();
		heroJump = transform.FindChild("Hero Jump").GetComponent<AudioSource>();
		startMenuButton = transform.FindChild("Start Menu Button").GetComponent<AudioSource>();

		success = transform.FindChild("Success").GetComponent<AudioSource>();
		failure = transform.FindChild("Failure").GetComponent<AudioSource>();
	}

	void Start() {
		ActorHero hero = God.ActorHero;
		hero.AddAudioSource(heroWalking);
		hero.AddAudioSource(heroJump);
		hero.AddAudioSource(startMenuButton);

		hero.AddAudioSource(success);
		hero.AddAudioSource(failure);
	}

}
