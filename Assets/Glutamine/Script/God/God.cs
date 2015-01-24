﻿using UnityEngine;
using System.Collections;

public class God {

	private static ActorWorld actorWorld;
	public static ActorWorld ActorWorld {
		get  { 
			if(actorWorld == null) {
				actorWorld = GameObject.Find("World").GetComponent<ActorWorld>();
			} 
			return actorWorld;
		}
	}
	
	private static ActorMainMenu actorMainMenu;
	public static ActorMainMenu ActorMainMenu {
		get  { 
			if(actorMainMenu == null) {
				actorMainMenu = GameObject.Find("Main Menu").GetComponent<ActorMainMenu>();
			} 
			return actorMainMenu;
		}
	}

	private static ActorPauseMenu actorPauseMenu;
	public static ActorPauseMenu ActorPauseMenu {
		get  { 
			if(actorPauseMenu == null) {
				actorPauseMenu = GameObject.Find("Pause Menu").GetComponent<ActorPauseMenu>();
			} 
			return actorPauseMenu;
		}
	}

	private static ActorHero actorHero;
	public static ActorHero ActorHero {
		get  { 
			if(actorHero == null) {
				actorHero = GameObject.Find("World/Hero").GetComponent<ActorHero>();
			} 
			return actorHero;
		}
	}

	private static ActorSFX actorSFX;
	public static ActorSFX ActorSFX {
		get  { 
			if(actorSFX == null) {
				actorSFX = GameObject.Find("SFX").GetComponent<ActorSFX>();
			} 
			return actorSFX;
		}
	}

	private static ActorMusic actorMusic;
	public static ActorMusic ActorMusic {
		get  { 
			if(actorMusic == null) {
				actorMusic = GameObject.Find("Music").GetComponent<ActorMusic>();
			} 
			return actorMusic;
		}
	}
}
