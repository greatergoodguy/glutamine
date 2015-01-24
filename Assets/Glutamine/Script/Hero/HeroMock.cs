using UnityEngine;
using System.Collections;

public class HeroMock : Hero_Base {

	public static readonly string TAG = typeof(HeroMock).Name;
	
	public override void Enter (ActorHero.Handler handler) {
		base.Enter (handler);
	}
	
	private static HeroMock instance;
	private HeroMock() {}
	public static HeroMock Instance {
		get 
		{
			if (instance == null) {
				instance = new HeroMock();}
			
			return instance;
		}
	}
}