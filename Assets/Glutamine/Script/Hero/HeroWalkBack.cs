using UnityEngine;
using System.Collections;

public class HeroWalkBack : Hero_Base {
	
	public static readonly string TAG = typeof(HeroWalkBack).Name;

	ActorHero.Handler handler;

	bool isFinished;
	Hero_Base nextHeroState;

	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
		this.handler = handler;

		isFinished = false;
		handler.SetAnimation(ActorHero.ANIMATION_WALK_BACK);

		God.ActorSFX.HeroWalking.Play();
	}

	public override void Update () {
		base.Update ();

		bool getKey_Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
		bool getKey_Down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
		bool getKey_Left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
		bool getKey_Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

		bool getKey_OnlyDown = getKey_Down && !getKey_Up;
		bool getKey_OnlyLeftOrOnlyRight = (getKey_Left && !getKey_Up) || (getKey_Right && !getKey_Up);

		if(handler.VelocityMagnitude > 0.1f && getKey_OnlyDown) {
			isFinished = true;
			nextHeroState = HeroWalkFront.Instance;
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

	private static HeroWalkBack instance;
	private HeroWalkBack() {}
	public static HeroWalkBack Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroWalkBack();}
			
			return instance;
		}
	}
}