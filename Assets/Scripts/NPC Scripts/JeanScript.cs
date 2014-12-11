using UnityEngine;
using System.Collections;

public class JeanScript : NPCBehaviour {
	// Use this for initialization
	override protected void Start () {
		base.Start();
		myNPCscript.ModInventory("Patate", 4);
		SetAnswer("Rumor", "I need these potatoes delivered to Bob, can you do it?");
		SetEvent("Rumor", "RumorDelivery");


	}

	override protected void Tick()
	{
	}

	public void RumorDelivery()
	{

		SetAnswer("Rumor", "Nope, nothing new under the sun");
		SetAnswer("Delivery", "Great, thanks! (4 Potatoes added)");
		SetEvent("Delivery", "DeliveryGive");
		
		player.AddPhrase("Delivery");

	}
	public void DeliveryGive()
	{
		SetAnswer("Delivery", "Did you already give the potatoes to Bob?");
		myNPCscript.ModInventory("Patate", -4);
		player.ModInventory("Patate", 4);
		RemoveEvent("Delivery", "DeliveryGive");
	}
}
