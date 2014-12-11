using UnityEngine;
using System.Collections;

public class BobScript : NPCBehaviour {
	// Use this for initialization
	override protected void Start () {
		base.Start();
		SetAnswer("Delivery", "Oh, you're supposed to deliver the potatoes, do you have them?");
		SetEvent("Delivery", "Delivery");


	}

	override protected void Tick()
	{
	}

	public void Delivery()
	{
		if(ModifyPlayerInventory("Patate",0)==4)
		{
			RemovePlayerPhrase("Delivery");
		}

	}

}
