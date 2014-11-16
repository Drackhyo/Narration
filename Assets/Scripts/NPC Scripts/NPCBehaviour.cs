using UnityEngine;
using System.Collections;

public abstract class NPCBehaviour : MonoBehaviour{
	protected  NPC myNPCscript;
	// Use this for initialization
	protected virtual void Start () {
		myNPCscript= gameObject.GetComponent<NPC>();
	}
	abstract protected void SpeechReaction(string speech);
	abstract protected void Tick();
	
}
