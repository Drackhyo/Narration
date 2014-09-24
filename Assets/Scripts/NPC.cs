using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public Dictionary<string,string> responseTable;
	public Dictionary<string,string> inventory;
	public string greetText;

	// Use this for initialization
	void Start () 
	{
	greetText="hello";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnMouseUpAsButton()
	{
		GameObject.Find("DialogManager").transform.GetComponent<DialogManager>().GreetNPC(name,greetText);
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
