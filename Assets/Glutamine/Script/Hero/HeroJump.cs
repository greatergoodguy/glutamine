using UnityEngine;
using System.Collections;

public class HeroJump : Hero_Base {
	
	public static readonly string TAG = typeof(HeroJump).Name;

	ActorHero.Handler handler;
	
	bool isFinished;

	bool isFirstTime = true;
	
	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;
		
		isFinished = false;
		
		handler.SetAnimation(ActorHero.ANIMATION_JUMP);

		if(!isFirstTime) {
			God.ActorSFX.HeroJump.Play();}
		else {
			isFirstTime = false;
		}
	}

	public override void Update () {
		base.Update ();

		if(handler.IsGrounded) {
			isFinished = true;
		}
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override Hero_Base GetNextHero () {
		return HeroStand.Instance;
	}
	
	private static HeroJump instance;
	private HeroJump() {}
	public static HeroJump Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroJump();}
			
			return instance;
		}
	}
}