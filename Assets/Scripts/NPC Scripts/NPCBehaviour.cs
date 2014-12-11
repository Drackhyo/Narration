using UnityEngine;
using System.Collections;

public abstract class NPCBehaviour : MonoBehaviour{
	protected  NPC myNPCscript;
	protected SpeechDB mySpeechDB;
	protected Playerinf player;
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

}
