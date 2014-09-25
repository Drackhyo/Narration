using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogManager : MonoBehaviour {

	bool displayMode=false; //true=interactif, false= text
	private Rect windowRect = new Rect (0, 4*Screen.height/5, Screen.width, Screen.height/5);
	string textToDisplay="Bienvenu dans le jeu";
	protected Vector2 scrollPosition = Vector2.zero;
	private List<string> speechOption;
	protected string currentNPC="Dialog Box";
	void OnGUI () {
		windowRect = GUI.Window (0, windowRect, WindowFunction,currentNPC);

		if(displayMode)
		{
			scrollPosition = GUI.BeginScrollView(new Rect(Screen.width*0.02f,4.2f*Screen.height/5,Screen.width,Screen.height/5), scrollPosition, new Rect(0, 0, 220, 200));
			int i=0;
			foreach(string option in speechOption)
			{
				if(GUI.Button(new Rect(0, i*20, 100, 20), option))
					GameObject.Find(currentNPC).GetComponent<NPC>().ConversationOption(option);
				i++;
			}
	

			GUI.EndScrollView();
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width*0.02f,4.2f*Screen.height/5,Screen.width,Screen.height/5),textToDisplay,"Label"))
			{
				DisplayList();
			}
		}
	}
	
	void WindowFunction (int windowID) {
		// Draw any Controls inside the window here
	}
	public void NPCAnswer(string name,string text)
	{
		if(name!=currentNPC)
		{
			textToDisplay=text;
			displayMode=false;
			currentNPC=name;
			foreach(GameObject npc in GameObject.FindGameObjectsWithTag("NPC"))
			{
				if(npc.name==name)
				{
					GameObject.Find("Player").transform.position=npc.transform.position;
					Vector2 nextPos =GameObject.Find("Player").transform.position;
					nextPos.x++;
					GameObject.Find("Player").transform.position=nextPos;
				}
			}
		}
		else
		{
			textToDisplay=text;
			displayMode=false;

		}
	}
	public void DisplayList()
	{
		speechOption=GameObject.Find("Player").transform.GetComponent<Playerinf>().getAvailablePhrases();
		displayMode=true;
	}
}
