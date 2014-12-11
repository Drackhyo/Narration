using UnityEngine;
using System.Collections;

public class JeanScript : NPCBehaviour {
	// Use this for initialization
	override protected void Start () {
		base.Start();
		ModifyInventory("Patate", 4);
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
		
		AddPlayerPhrase("Delivery");

	}
	public void DeliveryGive()
	{
		SetAnswer("Delivery", "Did you already give the potatoes to Bob?");
		ModifyInventory("Patate", -4);
		ModifyPlayerInventory("Patate", 4);
		RemoveEvent("Delivery", "DeliveryGive");
	}
}
