using UnityEngine;
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

		if(handler.VelocityMagnitude > 0.1f && Input.GetKey(KeyCode.DownArrow)) {
			isFinished = true;
			heroState = HeroWalkFront.Instance;
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