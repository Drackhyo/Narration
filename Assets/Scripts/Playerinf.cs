using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Playerinf : MonoBehaviour {

	List<string> availablePhrases;
	public Dictionary<string,int> inventory;//<itemName, amount>
	// Use this for initialization
	void Awake (){
		availablePhrases=new List<string>();
		inventory=new Dictionary<string, int>();
		AddPhrase("Trade");
		AddPhrase("Rumor");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public List<string> getAvailablePhrases()
	{
		return availablePhrases;
	}
	public bool AddPhrase(string phrase)
	{
		if(availablePhrases.Contains(phrase))
			return false;
		availablePhrases.Add(phrase);
		return true;
	}
	public bool RemovePhrase(string phrase)
	{
		if(!availablePhrases.Contains(phrase))
			return false;
		availablePhrases.Remove(phrase);
		return true;
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

}
