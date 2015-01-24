using UnityEngine;
using System.Collections;

public class SeTiWorld : SeTi_Base {

	public static readonly string TAG = typeof(SeTiWorld).Name;

	bool isFinished;

	bool isPaused;
	bool isFirstTrackPlaying = true;

	AudioSource firstTrack;
	AudioSource secondTrack;

	AudioSource activeTrack;


	public override void Enter () {
		base.Enter ();

		God.ActorPauseMenu.actionResume += () => {
			UtilLogger.Log(TAG, "actionResume");
			Resume();
		};

		God.ActorPauseMenu.actionQuit += () => {
			UtilLogger.Log(TAG, "actionQuit");
			isFinished = true;
		};

		firstTrack = God.ActorMusic.TestFirstTrack;
		//firstTrack = God.ActorSFX.HeroWalking;
		firstTrack.Play();
		firstTrack.loop = false;

		secondTrack = God.ActorMusic.TestSecondTrack;
		secondTrack.loop = true;

		activeTrack = firstTrack;

		isFinished = false;
		isFirstTrackPlaying = true;
		Resume();
	}

	public override void Update () {
		base.Update ();

		if(Input.GetKeyDown(KeyCode.Escape)) {
			Pause();
		}

		if(isFirstTrackPlaying && !firstTrack.isPlaying && !isPaused) {
			StartSecondTrack();
		}
	}

	void StartSecondTrack() {
		secondTrack.Play();
		activeTrack = secondTrack;
		isFirstTrackPlaying = false;
	}
	
	public override void Exit () {
		base.Exit ();
		
		God.ActorPauseMenu.TurnOff();
		firstTrack.Stop();
		secondTrack.Stop();
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override SeTi_Base GetNextSeason () {
		return SeTiMainMenu.Instance;
	}

	void Pause() {
		isPaused = true;
		Time.timeScale = 0;
		God.ActorPauseMenu.TurnOn();
		activeTrack.Pause();
	}

	void Resume() {
		isPaused = false;
		Time.timeScale = 1;
		God.ActorPauseMenu.TurnOff();
		activeTrack.Play();
	}

	private static SeTiWorld instance;
	private SeTiWorld() {}
	public static SeTiWorld Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiWorld();}
			
			return instance;
		}
	}
}