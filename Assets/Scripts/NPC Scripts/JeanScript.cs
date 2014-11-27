using UnityEngine;
using System.Collections;

public class JeanScript : NPCBehaviour {
	// Use this for initialization
	void Start () {
		base.Start();
		int lol = 4;
		int asda=myNPCscript.ModInventory("Patate", lol);
		mySpeechDB.SetAnswer(name, "Rumor", "petitpenis");
		mySpeechDB.SetEvent(name,"Rumor", "grospenis");


	}

	override protected void Tick()
	{
	}
	override protected void SpeechReaction(string speech)
	{

	}
	void grospenis()
	{
		Debug.Log("grospenis");
	}
}
