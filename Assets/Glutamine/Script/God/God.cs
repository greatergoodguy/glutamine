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

	static Object oClonerSpeech;
	public static GameObject CreateSpeechBubble(string text, Transform parent) {
		if(oClonerSpeech == null) {
			oClonerSpeech = Resources.Load("Speech", typeof(GameObject));}

		GameObject goSpeech = GameObject.Instantiate(oClonerSpeech) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 3.5f, 0);

		AISpeech speech = goSpeech.GetComponent<AISpeech>();
		speech.SetText(text);

		return goSpeech;
	}

	static Object oClonerSpeechSmall;
	public static GameObject CreateSpeechBubbleSmall(string text, Transform parent) {
		if(oClonerSpeechSmall == null) {
			oClonerSpeechSmall = Resources.Load("Speech Small", typeof(GameObject));}
		
		GameObject goSpeech = GameObject.Instantiate(oClonerSpeechSmall) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 3.5f, 0);
		
		AISpeech speech = goSpeech.GetComponent<AISpeech>();
		speech.SetText(text);
		
		return goSpeech;
	}

	static Object oClonerSpeechMedium;
	public static GameObject CreateSpeechBubbleMedium(string text, Transform parent) {
		if(oClonerSpeechMedium == null) {
			oClonerSpeechMedium = Resources.Load("Speech Medium", typeof(GameObject));}
		
		GameObject goSpeech = GameObject.Instantiate(oClonerSpeechMedium) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 3.5f, 0);
		
		AISpeech speech = goSpeech.GetComponent<AISpeech>();
		speech.SetText(text);
		
		return goSpeech;
	}

	static Object oClonerSpeechLarge;
	public static GameObject CreateSpeechBubbleLarge(string text, Transform parent) {
		if(oClonerSpeechLarge == null) {
			oClonerSpeechLarge = Resources.Load("Speech Large", typeof(GameObject));}
		
		GameObject goSpeech = GameObject.Instantiate(oClonerSpeechLarge) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 3.5f, -0.3f);
		
		AISpeech speech = goSpeech.GetComponent<AISpeech>();
		speech.SetText(text);
		
		return goSpeech;
	}

	static Object oClonerActionBubble;
	public static GameObject CreateSpeechActionBubble(Transform parent) {
		if(oClonerActionBubble == null) {
			oClonerActionBubble = Resources.Load("Action Bubble", typeof(GameObject));}
		
		GameObject goSpeech = GameObject.Instantiate(oClonerActionBubble) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 0, -0.3f);
		
		return goSpeech;
	}

	static Object oClonerSpeechFront;
	public static GameObject CreateSpeechBubbleFront(string text, Transform parent) {
		if(oClonerSpeechFront == null) {
			oClonerSpeechFront = Resources.Load("Speech Small", typeof(GameObject));}
		
		GameObject goSpeech = GameObject.Instantiate(oClonerSpeechFront) as GameObject;
		goSpeech.transform.parent = parent;
		goSpeech.transform.localPosition = new Vector3(0, 1.3f, -0.8f);
		
		AISpeech speech = goSpeech.GetComponent<AISpeech>();
		speech.SetText(text);
		
		return goSpeech;
	}
}
