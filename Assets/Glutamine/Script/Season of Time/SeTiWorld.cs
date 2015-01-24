using UnityEngine;
using System.Collections;

public class SeTiWorld : SeTi_Base {
	
	private static SeTiWorld instance;
	private SeTiWorld() {}
	public static SeTiWorld Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiWorld();}
			
			return instance;
		}
	}
}