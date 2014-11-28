using UnityEngine;
using System.Collections;

public class JeanScript : NPCBehaviour {
	// Use this for initialization
	override protected void Start () {
		base.Start();
		myNPCscript.ModInventory("Patate", 4);
		mySpeechDB.SetAnswer(name,"Rumor", "I need these potatoes delivered to Bob, can you do it?");
		mySpeechDB.SetEvent(name,"Rumor", "RumorDelivery");


	}

	override protected void Tick()
	{
	}

	public void RumorDelivery()
	{

		mySpeechDB.SetAnswer(name,"Rumor", "Nope, nothing new under the sun");
		mySpeechDB.SetAnswer(name,"Delivery", "Great, thanks! (4 Potatoes added)");
		mySpeechDB.SetEvent(name,"Delivery", "DeliveryGive");
		mySpeechDB.RemoveEvent(name,"Rumor", "RumorDelivery");
		player.AddPhrase("Delivery");

	}
	public void DeliveryGive()
	{
		mySpeechDB.SetAnswer(name,"Delivery", "Did you already give the potatoes to Bob?");
		myNPCscript.ModInventory("Patate", -4);
		player.ModInventory("Patate", 4);
		mySpeechDB.RemoveEvent(name, "Delivery", "DeliveryGive");
	}
}
