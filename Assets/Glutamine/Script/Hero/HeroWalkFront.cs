using UnityEngine;
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

		God.ActorSFX.HeroWalking.Play();
	}

	public override void Update () {
		base.Update ();

		bool getKey_Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
		bool getKey_Down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
		bool getKey_Left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
		bool getKey_Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

		bool getKey_OnlyUp = getKey_Up && !getKey_Down;
		bool getKey_OnlyLeftOrOnlyRight = (getKey_Left && !getKey_Down) || (getKey_Right && !getKey_Down);

		if(handler.VelocityMagnitude > 0.1f && getKey_Up) {
			isFinished = true;
			nextHeroState = HeroWalkBack.Instance;
		}
		else if(handler.VelocityMagnitude > 0.1f && getKey_OnlyLeftOrOnlyRight) {
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

		God.ActorSFX.HeroWalking.Pause();
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