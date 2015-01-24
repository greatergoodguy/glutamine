using UnityEngine;
using System.Collections;

public class ActorHero : Actor_Base {

	public static readonly string TAG = typeof(ActorHero).Name;

	public static readonly int ANIMATION_STAND = 0;
	public static readonly int ANIMATION_WALK = 1;
	public static readonly int ANIMATION_JUMP = 2;
	public static readonly int ANIMATION_WALK_FRONT = 3;

	Hero_Base heroState = HeroStand.Instance;

	ActorHero.Handler handler;

	CharacterController characterController;

	ActorHeroCamera heroCamera;
	ActorHeroVisual heroVisual;
	Animator animator;

	public void AddChildToCamera(AudioSource child) {
		AddChildToCamera(child.gameObject);
	}

	public void AddChildToCamera(GameObject child) {
		child.transform.parent = heroCamera.transform;
	}

	void Awake() {
		characterController = GetComponent<CharacterController>();

		heroCamera = transform.FindChild("Main Camera").GetComponent<ActorHeroCamera>();

		heroVisual = transform.FindChild("Visual").GetComponent<ActorHeroVisual>();
		animator = heroVisual.GetComponent<Animator>();
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
			hero.animator.SetInteger("Animation", animation);
		}

		public float VelocityMagnitude {
			get {
				return hero.characterController.velocity.magnitude;
			}
		}

		public bool IsGrounded {
			get {
				return hero.characterController.isGrounded;
			}
		}

	}
}
