using UnityEngine;
using System.Collections;

public class SeTiWorld : SeTi_Base {

	public static readonly string TAG = typeof(SeTiWorld).Name;

	bool isFinished;

	bool isPaused;

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

		isFinished = false;

		Resume();
	}

	public override void Update () {
		base.Update ();

		if(Input.GetKeyDown(KeyCode.Escape)) {
			Pause();
		}
	}

	
	public override void Exit () {
		base.Exit ();
		
		God.ActorPauseMenu.TurnOff();
		God.ActorMusic.WorldTheme.Stop();
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
		God.ActorMusic.WorldTheme.Pause();
	}

	void Resume() {
		isPaused = false;
		Time.timeScale = 1;
		God.ActorPauseMenu.TurnOff();
		God.ActorMusic.WorldTheme.Play();
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