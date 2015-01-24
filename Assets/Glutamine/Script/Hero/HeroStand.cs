using UnityEngine;
using System.Collections;

public class HeroStand : Hero_Base {

	public static readonly string TAG = typeof(HeroStand).Name;

	ActorHero.Handler handler;

	bool isFinished;

	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;

		isFinished = false;
	}

	public override void Update () {
		base.Update ();

		if(handler.VelocityMagnitude > 0.1f) {
			isFinished = true;
		}
	}

	public override void Exit () {
		base.Exit ();
	}

	public override bool IsFinished () {
		return isFinished;
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