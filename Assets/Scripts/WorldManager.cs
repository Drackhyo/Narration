using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {
	GameObject[] NPCs;
	// Use this for initialization
	void Start () {
		NPCs=GameObject.FindGameObjectsWithTag("NPC");

	}
	public void UpdateWorld()
	{
		foreach(GameObject actor in NPCs)
		{
			actor.SendMessage("Tick");
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
