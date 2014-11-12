using UnityEngine;
using System.Collections;

public class JeanScript : MonoBehaviour {
	NPC myNPCscript;
	// Use this for initialization
	void Start () {
		myNPCscript= gameObject.GetComponent<NPC>();
		int lol = 4;
		int asda=myNPCscript.ModInventory("Patate", lol);
		Debug.Log (asda);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Tick()
	{

	}
}
