using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public string NPCName;
	public Dictionary<string,string> responseTable;
	public Dictionary<string,string> inventory;
	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnMouseUpAsButton()
	{
		GameObject.Find("DialogManager").transform.GetComponent<DialogManager>().DisplayText(NPCName);
	}
	
	void OnGreet()
	{
		
	}

	void ConversationOption(string key)
	{
		if (responseTable.ContainsKey(key)) 
		{

		}
		else
		{
			//getGenericAnswer
		}
			
	}
}
