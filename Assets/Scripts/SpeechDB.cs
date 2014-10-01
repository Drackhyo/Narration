using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpeechDB : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	// Use this for initialization
	void Start () {
		responseTable=new Dictionary<string,string>();
		responseTable.Add("BobRumor","A rumor");
		responseTable.Add("BobRumor1","A rumor");
		responseTable.Add("BobRumor2","Another rumor");
	}
	public string GetAnswer( string NPCname, string key)
	{
		string answer = "";
		if(responseTable.TryGetValue(NPCname+key,out answer))
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
