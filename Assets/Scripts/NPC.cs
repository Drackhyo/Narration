using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public Dictionary<string,int> inventory;//<itemName, amount>
	public string greetText="hello";
	Transform dialog;

	// Use this for initialization
	void Start () 
	{
		inventory=new Dictionary<string,int>();
		inventory.Add("Iron",0);
		dialog=GameObject.Find("DialogManager").transform;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnMouseUpAsButton()
	{
		dialog.GetComponent<DialogManager>().NPCAnswer(name,greetText);
	}
	public int ModInventory(string itemName, int amount)
	{
		int currentAmount;
		inventory.TryGetValue(itemName, out currentAmount);///wtf piece of shit does not work
		if(currentAmount<=0)
		{
			Debug.Log("loll") ;
			currentAmount+=amount;
			if(currentAmount>=0)
				inventory.Add(itemName,currentAmount);
			return currentAmount;
		}
		else if (amount>0)
		{
			inventory.Add(itemName,amount);
			return amount;
		}
		else
		return -1;
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
	public void Tick ()
	{
		transform.position+=(Random.insideUnitSphere/3);
		int lol=0;
		if(inventory.TryGetValue("Patate",out lol))
		 {
			Debug.Log(name);
		   Debug.Log(lol);
		}
	}
}
