using UnityEngine;
using System.Collections;

public class ActorHero : Actor_Base {

	public static readonly string TAG = typeof(ActorHero).Name;

	public static readonly int HERO_STATE_STAND = 0;
	public static readonly int HERO_STATE_WALK = 1;

	Hero_Base heroState = HeroMock.Instance;

	CharacterController characterController;

	ActorHero.Handler handler;

	ActorHeroVisual heroVisual;

	void Awake() {
		heroVisual = transform.FindChild("Visual").GetComponent<ActorHeroVisual>();
		characterController = GetComponent<CharacterController>();
	}

	void Start() {
		handler = new ActorHero.Handler(this);
		
		heroState.Enter(handler);
		UtilLogger.Log(TAG, heroState.GetType().Name + ": Enter");
	}

	void Update() {
		heroState.Update();
		
		if(heroState.IsFinished()) {
			heroState.Exit();
			UtilLogger.Log(TAG, heroState.GetType().Name + ": Exit");
			heroState = heroState.GetNextHero();
			heroState.Enter(handler);
			UtilLogger.Log(TAG, heroState.GetType().Name + ": Enter");
		}
	}

	Vector3 posOld = Vector3.zero;
	Vector3 posCurrent = Vector3.zero;

	bool isMoving;

	public class Handler {
		
		ActorHero hero;
		
		public Handler(ActorHero hero) {
			this.hero = hero;
		}
		
		public void SetAnimation(int animation) {
		}

		public float VelocityMagnitude {
			get {
				return hero.characterController.velocity.magnitude;
			}
		}

	}
}
