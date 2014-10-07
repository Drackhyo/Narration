using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpeechDB : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	public Dictionary<string,string> itemSpeechTable;
	// Use this for initialization
	void Start () {
		responseTable=new Dictionary<string,string>();
		responseTable.Add("BobRumor","A rumor");
		responseTable.Add("BobRumor1","A rumor");
		responseTable.Add("BobRumor2","Another rumor");
		responseTable.Add("Rumor","A generic rumor");

		responseTable.Add("BobIron", "Here, take some Iron to Jean");
		responseTable.Add("BobIron1", "Here, take some Iron to Jean");
		responseTable.Add("BobIron2", "You already have some Iron");

		responseTable.Add("JeanIron", "ERROR");
		responseTable.Add("JeanIron1", "You don't have any Iron");
		responseTable.Add("JeanIron2", "Thanks!");

	}
	public string GetAnswer( string NPCname, string key)
	{
		string answer = "";
		if(responseTable.TryGetValue(NPCname+key,out answer))
			return answer;
		else if(responseTable.TryGetValue(key,out answer))
			return answer;
		else
			return "";
	}
	public void SetAnswer ( string NPCname, string key, int number)
	{
		string answer = "";
		if(responseTable.ContainsKey(NPCname+key))
		{
			if(responseTable.TryGetValue(NPCname+key+number.ToString(),out answer))
			{
			responseTable.Remove (NPCname+key);
			responseTable.Add(NPCname+key,answer);
			}
		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}
