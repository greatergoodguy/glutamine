﻿using UnityEngine;
using System.Collections;

public class HeroStand : Hero_Base {

	public static readonly string TAG = typeof(HeroStand).Name;

	ActorHero.Handler handler;

	bool isFinished;

	Hero_Base heroState;

	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;

		isFinished = false;
		handler.SetAnimation(ActorHero.ANIMATION_STAND);
	}

	public override void Update () {
		base.Update ();

		bool getKey_Down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
		bool getKey_Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);

		if(handler.VelocityMagnitude > 0.1f && getKey_Down) {
			isFinished = true;
			heroState = HeroWalkFront.Instance;
		}
		else if(handler.VelocityMagnitude > 0.1f && getKey_Up) {
			isFinished = true;
			heroState = HeroWalkBack.Instance;
		}
		else if(handler.VelocityMagnitude > 0.1f) {
			isFinished = true;
			heroState = HeroWalk.Instance;
		}
		else if(!handler.IsGrounded) {
			isFinished = true;
			heroState = HeroJump.Instance;
		}
	}

	public override void Exit () {
		base.Exit ();
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override Hero_Base GetNextHero () {
		return HeroWalk.Instance;
	}
	
	private static HeroStand instance;
	private HeroStand() {}
	public static HeroStand Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroStand();}
			
			return instance;
		}
	}
}