using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpeechDB : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	// Use this for initialization
	void Start () {
		responseTable=new Dictionary<string,string>();
		responseTable.Add("BobRumor","A rumor");
	}
	public string GetAnswer( string NPCname, string key)
	{
		string answer = "";
		if(responseTable.TryGetValue(NPCname+key,out answer))
			return answer;
		else
			return "";
	}
	// Update is called once per frame
	void Update () {
	
	}
}
