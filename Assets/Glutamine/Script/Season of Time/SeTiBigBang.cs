using UnityEngine;
using System.Collections;

public class SeTiBigBang : SeTi_Base {
	
	public static readonly string TAG = typeof(SeTiBigBang).Name;
	
	public override void Enter () {
		base.Enter ();

		God.ActorMainMenu.TurnOff();
		God.ActorPauseMenu.TurnOff();
	}
	
	public override bool IsFinished () {
		return true;
	}
	
	public override SeTi_Base GetNextSeason () {
		//return SeTiMainMenu.Instance;
		return SeTiWorld.Instance;
	}
	
	private static SeTiBigBang instance;
	public static SeTiBigBang Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiBigBang();}
			
			return instance;
		}
	}
}