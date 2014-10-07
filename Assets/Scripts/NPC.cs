using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public Dictionary<string,string> itemInteractions;//<SpeechKey, itemName>
	public Dictionary<string,float> inventory;//<itemName, amount>
	public string greetText;
	Transform dialog;

	// Use this for initialization
	void Start () 
	{
		dialog=GameObject.Find("DialogManager").transform;
		greetText="hello";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnMouseUpAsButton()
	{
		dialog.GetComponent<DialogManager>().NPCAnswer(name,greetText);
	}


	public void ConversationOption(string key)
	{

		string speech = dialog.GetComponent<SpeechDB>().GetAnswer(name, key);
		if (speech == "")
		{
			dialog.GetComponent<DialogManager>().NPCAnswer(name,"I don't know what you're talking about");
			dialog.GetComponent<SpeechDB>().SetAnswer(name, "Rumor", 2);
		}
		else
			dialog.GetComponent<DialogManager>().NPCAnswer(name,speech);

			
	}
	public void tick (){

	}
}
