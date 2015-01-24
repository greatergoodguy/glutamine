using UnityEngine;
using System.Collections;

public class HeroWalk : Hero_Base {
	
	public static readonly string TAG = typeof(HeroWalk).Name;
	
	ActorHero.Handler handler;
	
	bool isFinished;
	
	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;
		
		isFinished = false;

		handler.SetAnimation(ActorHero.ANIMATION_WALK);
	}
	
	public override void Update () {
		base.Update ();
		
		if(handler.VelocityMagnitude < 0.1f) {
			isFinished = true;
		}
	}
	
	public override void Exit () {
		base.Exit ();
	}
	
	public override bool IsFinished () {
		return isFinished;
	}
	
	public override Hero_Base GetNextHero () {
		return HeroStand.Instance;
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