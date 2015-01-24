using UnityEngine;
using System.Collections;

public class God {

	private static ActorWorld actorWorld;
	public static ActorWorld ActorWorld {
		get  { 
			if(actorWorld == null) {
				actorWorld = GameObject.Find("World").GetComponent<ActorWorld>();
			} 
			return actorWorld;
		}
	}
	
	private static ActorMainMenu actorMainMenu;
	public static ActorMainMenu ActorMainMenu {
		get  { 
			if(actorMainMenu == null) {
				actorMainMenu = GameObject.Find("Main Menu").GetComponent<ActorMainMenu>();
			} 
			return actorMainMenu;
		}
	}
}
