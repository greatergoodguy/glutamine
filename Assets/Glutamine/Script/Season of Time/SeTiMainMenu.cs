﻿using UnityEngine;
using System;
using System.Collections;


public class SeTiMainMenu : SeTi_Base {
	
	public static readonly string TAG = typeof(SeTiMainMenu).Name;

	bool isFinished;

	public override void Enter () {
		base.Enter ();

		God.ActorMainMenu.TurnOn();
		God.ActorMainMenu.actionPlay += () => {
			UtilLogger.Log(TAG, "actionPlay");
			God.ActorSFX.StartMenuButton.Play();
			isFinished = true;
		};

		isFinished = false;
		God.ActorMusic.StoryScene.Play();
	}

	public override void Exit () {
		base.Exit ();

		God.ActorMainMenu.TurnOff();
		God.ActorMusic.StoryScene.Stop();
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override SeTi_Base GetNextSeason () {
		return SeTiWorld.Instance;
	}

	private static SeTiMainMenu instance;
	public static SeTiMainMenu Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiMainMenu();}
			
			return instance;
		}
	}
}