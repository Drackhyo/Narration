using UnityEngine;
using System.Collections;

public abstract class NPCBehaviour : MonoBehaviour{
	protected  NPC myNPCscript;
	protected SpeechDB mySpeechDB;
	// Use this for initialization
	protected virtual void Start () {
		myNPCscript= gameObject.GetComponent<NPC>();
		mySpeechDB= GameObject.Find("DialogManager").GetComponent<SpeechDB>();
	}
	abstract protected void SpeechReaction(string speech);
	abstract protected void Tick();
	
}
