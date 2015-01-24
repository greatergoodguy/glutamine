﻿using UnityEngine;
using System.Collections;

public class HeroWalk : Hero_Base {
	
	public static readonly string TAG = typeof(HeroWalk).Name;
	
	ActorHero.Handler handler;
	
	bool isFinished;
	Hero_Base nextHeroState;
	
	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;
		
		isFinished = false;

		handler.SetAnimation(ActorHero.ANIMATION_WALK);

		God.ActorSFX.HeroWalking.Play();
	}
	
	public override void Update () {
		base.Update ();

		if(handler.VelocityMagnitude > 0.1f && Input.GetKey(KeyCode.DownArrow)) {
			isFinished = true;
			nextHeroState = HeroWalkFront.Instance;
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

		God.ActorSFX.HeroWalking.Stop();
	}
	
	public override bool IsFinished () {
		return isFinished;
	}
	
	public override Hero_Base GetNextHero () {
		return nextHeroState;
	}
	
	private static HeroWalk instance;
	private HeroWalk() {}
	public static HeroWalk Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroWalk();}
			
			return instance;
		}
	}
}