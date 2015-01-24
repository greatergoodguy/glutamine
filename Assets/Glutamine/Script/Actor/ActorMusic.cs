using UnityEngine;
using System.Collections;

public class ActorMusic : Actor_Base {

	AudioSource worldTheme;
	public AudioSource WorldTheme {
		get {
			return worldTheme;
		}
	}

	AudioSource storyScene;
	public AudioSource StoryScene {
		get {
			return storyScene;
		}
		
	}

	void Awake() {
		worldTheme = transform.FindChild("World Theme").GetComponent<AudioSource>();
		storyScene = transform.FindChild("Story Scene").GetComponent<AudioSource>();
	}

	void Start() {
		ActorHero hero = God.ActorHero;
		hero.AddCameraChild(worldTheme.gameObject);
		hero.AddCameraChild(storyScene.gameObject);

	}
}
