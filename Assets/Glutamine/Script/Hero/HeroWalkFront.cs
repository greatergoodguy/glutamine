﻿using UnityEngine;
using System.Collections;

public class HeroWalkFront : Hero_Base {
	
	public static readonly string TAG = typeof(HeroWalkFront).Name;

	ActorHero.Handler handler;

	bool isFinished;
	Hero_Base nextHeroState;

	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;

		isFinished = false;
		handler.SetAnimation(ActorHero.ANIMATION_WALK_FRONT);
	}

	public override void Update () {
		base.Update ();

		bool getKeyUp = Input.GetKey(KeyCode.UpArrow);

		if(handler.VelocityMagnitude > 0.1f && getKeyUp) {
			isFinished = true;
			nextHeroState = HeroWalk.Instance;
		}
		else if(handler.VelocityMagnitude < 0.1f) {
			isFinished = true;
			nextHeroState = HeroStand.Instance;
		}
		else if(!handler.IsGrounded) {
			isFinished = true;
			nextHeroState = HeroJump.Instance;
		}
	}

	public override void Exit () {
		base.Exit ();
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override Hero_Base GetNextHero () {
		return nextHeroState;
	}

	private static HeroWalkFront instance;
	private HeroWalkFront() {}
	public static HeroWalkFront Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroWalkFront();}
			
			return instance;
		}
	}
}