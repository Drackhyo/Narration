using UnityEngine;
using System.Collections;

public abstract class NPCBehaviour : MonoBehaviour{
	private  NPC myNPCscript;
	private SpeechDB mySpeechDB;
	private Playerinf player;
	// Use this for initialization
	virtual protected void Start ()
	{}
	public void Awake() {
		myNPCscript= gameObject.GetComponent<NPC>();
		mySpeechDB= GameObject.Find("DialogManager").GetComponent<SpeechDB>();
		player=GameObject.Find("Player").GetComponent<Playerinf>();
	}
	abstract protected void Tick();
	protected void SetAnswer(string key, string answer)
	{
		mySpeechDB.SetAnswer(name,key, answer);
	}
	protected void SetEvent(string key, string eventName)
	{
		mySpeechDB.SetEvent(name,key, eventName);
	}
	protected void RemoveEvent(string key, string eventName)
	{
		mySpeechDB.RemoveEvent(name,key, eventName);
	}
	protected int ModifyInventory(string itemName, int amount)
	{
		return myNPCscript.ModInventory(itemName,amount);
	}
	protected int ModifyPlayerInventory(string itemName, int amount)
	{
		return player.ModInventory(itemName,amount);
	}
	protected bool AddPlayerPhrase(string phrase)
	{
		return player.AddPhrase(phrase);
	}
	protected bool RemovePlayerPhrase(string phrase)
	{
		return player.RemovePhrase(phrase);
	}
}
