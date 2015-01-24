using UnityEngine;
using System.Collections;

public class Hero_Base {
	
	ActorHero.Handler handler;
	
	public virtual void Enter(ActorHero.Handler handler) {
		this.handler = handler;
	}
	public virtual void Update() {}
	public virtual void Exit() {}
	
	public virtual bool IsFinished() { return false;}
	public virtual Hero_Base GetNextHero() { return HeroMock.Instance;}
}
