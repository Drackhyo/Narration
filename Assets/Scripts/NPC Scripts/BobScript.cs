using UnityEngine;
using System.Collections;

public class BobScript : NPCBehaviour {
	// Use this for initialization
	override protected void Start () {
		base.Start();
		mySpeechDB.SetAnswer(name,"Delivery", "Oh, you're supposed to deliver the potatoes, do you have them?");
		mySpeechDB.SetEvent(name,"Delivery", "Delivery");


	}

	override protected void Tick()
	{
	}

	public void Delivery()
	{
		if(player.ModInventory("Patate",0)==4)
		{
			player.RemovePhrase("Delivery");
		}

	}

}
