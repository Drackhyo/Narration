using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour {
	public Dictionary<string,int> inventory;//<itemName, amount>
	public string greetText="hello";
	Transform dialog;

	// Use this for initialization
	void Awake () 
	{
		inventory=new Dictionary<string,int>();
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

	public int ModInventory(string itemName, int amount)//pour modifier et obtenir le compte d'inventaire
	{

		int currentAmount;
		if(inventory.TryGetValue(itemName, out currentAmount))
		{
			if(currentAmount>=-1*amount)
			{
				inventory[itemName]+=amount;
				return inventory[itemName];
			}
		}
		else
		{
			if(amount>=0)
			{
				inventory.Add(itemName,amount);
				return amount;
			}
		}
		return -1;
	}


	public void ConversationOption(string key)
	{

		string speech = dialog.GetComponent<SpeechDB>().GetAnswer(name, key);
		if (speech == "")
		{
			dialog.GetComponent<DialogManager>().NPCAnswer(name,"I don't know what you're talking about");
		}
		else
			dialog.GetComponent<DialogManager>().NPCAnswer(name,speech);

			
	}
	public void Tick ()
	{
		transform.position+=(Random.insideUnitSphere/3);

	}
}
