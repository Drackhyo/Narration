using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpeechDB : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	public Dictionary<string,string> eventTable;
	// Use this for initialization
	void Awake (){
		responseTable=new Dictionary<string,string>();
		eventTable=new Dictionary<string, string>();
		responseTable.Add("BobRumor","A rumor");
		responseTable.Add("Rumor","A generic rumor");
		
		responseTable.Add("BobIron", "Here, take some Iron to Jean");
		
		
		responseTable.Add("JeanIron", "ERROR");
		responseTable.Add("JeanIron1", "You don't have any Iron");
		responseTable.Add("JeanIron2", "Thanks!");

	}
	void Start () {


	}

	public string GetAnswer( string NPCname, string key)
	{
		string answer = "";
		if(responseTable.TryGetValue(NPCname+key,out answer))//NPC specific answer for topic
		{
			string eventName;
			if(eventTable.TryGetValue(NPCname+key,out eventName))
			{
				GameObject NPCs=GameObject.Find(NPCname);
					NPCs.SendMessage(eventName);
			}
			return answer;
		}	
		else if(responseTable.TryGetValue(key,out answer))//generic answer for topic
			return answer;
		else
			return "";//Returns "error" speech, default "I don't know what you're talking about"
	}
	public void SetEvent( string NPCname, string key, string eventName)//eventName==method to call
	{
		if(eventTable.ContainsKey(NPCname+key))
			eventTable[NPCname+key]=eventName;
		
		else
			eventTable.Add(NPCname+key,eventName);
		
	}
	public void SetAnswer ( string NPCname, string key, string answer)//for generic answer, NPCName==""
	{

		if(responseTable.ContainsKey(NPCname+key))
			responseTable[NPCname+key]=answer;

		else
			responseTable.Add(NPCname+key,answer);
		

	}
	public bool RemoveAnswer (string NPCname, string key)
	{
		if(responseTable.ContainsKey(NPCname+key))
		{
			responseTable.Remove(NPCname+key);
			return true;
		}
		return false;
	}



	// Update is called once per frame
	void Update () {
	
	}
}
