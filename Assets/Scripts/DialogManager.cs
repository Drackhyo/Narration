using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogManager : MonoBehaviour {

	bool displayMode=false; //true=interactif, false= text
	private Rect windowRect = new Rect (0, 4*Screen.height/5, Screen.width, Screen.height/5);
	string textToDisplay="Bienvenu dans le jeu";
	public Vector2 scrollPosition = Vector2.zero;
	private List<string> speechOption;
	void OnGUI () {
		windowRect = GUI.Window (0, windowRect, WindowFunction, "Dialog Box");

		if(displayMode)
		{
			scrollPosition = GUI.BeginScrollView(new Rect(Screen.width*0.02f,4.2f*Screen.height/5,Screen.width,Screen.height/5), scrollPosition, new Rect(0, 0, 220, 200));
			int i=0;
			foreach(string option in speechOption)
			{
				GUI.Button(new Rect(0, i*20, 100, 20), option);
				i++;
			}
	

			GUI.EndScrollView();
		}
		else
		{
			if(GUI.Button(new Rect(Screen.width*0.02f,4.2f*Screen.height/5,Screen.width,Screen.height/5),textToDisplay,"Label"))
			{
				List<string> availablePhrases=new List<string>();
				availablePhrases.Add("Trade");
				availablePhrases.Add("Rumor");
				DisplayList(availablePhrases);
			}
		}
	}
	
	void WindowFunction (int windowID) {
		// Draw any Controls inside the window here
	}
	public void DisplayText(string text)
	{
		textToDisplay=text;
		displayMode=false;
	}
	public void DisplayList(List<string> speechList)
	{
		speechOption=speechList;
		displayMode=true;
	}
}
