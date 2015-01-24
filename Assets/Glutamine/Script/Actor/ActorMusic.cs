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

	AudioSource testFirstTrack;
	public AudioSource TestFirstTrack {
		get {
			return testFirstTrack;
		}
	}

	AudioSource testSecondTrack;
	public AudioSource TestSecondTrack {
		get {
			return testSecondTrack;
		}
	}

	void Awake() {
		worldTheme = transform.FindChild("World Theme").GetComponent<AudioSource>();
		storyScene = transform.FindChild("Story Scene").GetComponent<AudioSource>();

		testFirstTrack = transform.FindChild("Test First Track").GetComponent<AudioSource>();
		testSecondTrack = transform.FindChild("Test Second Track").GetComponent<AudioSource>();
	}

	void Start() {
		ActorHero hero = God.ActorHero;
		hero.AddChildToCamera(worldTheme);
		hero.AddChildToCamera(storyScene);
		hero.AddChildToCamera(testFirstTrack);
		hero.AddChildToCamera(testSecondTrack);

	}
}
