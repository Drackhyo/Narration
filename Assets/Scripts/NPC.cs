using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	public Dictionary<string,string> inventory;
	public string greetText;
	DialogManager dialog;

	// Use this for initialization
	void Start () 
	{
		dialog=GameObject.Find("DialogManager").transform.GetComponent<DialogManager>();
	greetText="hello";
		responseTable=new Dictionary<string,string>();
		responseTable.Add("Rumor","A rumor");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnMouseUpAsButton()
	{
		dialog.NPCAnswer(name,greetText);
	}


	public void ConversationOption(string key)
	{
		if (responseTable.ContainsKey(key)) 
		{
			string answer="";
			responseTable.TryGetValue(key,out answer);
			dialog.NPCAnswer(name,answer);
		}
		else
		{
			dialog.NPCAnswer(name,"I don't know what you're talking about");
			//getGenericAnswer
		}
			
	}
}
