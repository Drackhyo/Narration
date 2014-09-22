using UnityEngine;
using System.Collections;

public class DialogManager : MonoBehaviour {

	bool displayMode; //true=interactif, false= text
	private Rect windowRect = new Rect (0, 4*Screen.height/5, Screen.width, Screen.height/5);
	string textToDisplay="Bienvenu dans le jeu";
	
	void OnGUI () {
		windowRect = GUI.Window (0, windowRect, WindowFunction, "Dialog Box");

		if(displayMode)
		{

		}
		else
			GUI.Label(new Rect(Screen.width*0.02f,4.2f*Screen.height/5,Screen.width,Screen.height/5),textToDisplay);
	}
	
	void WindowFunction (int windowID) {
		// Draw any Controls inside the window here
	}
	public void DisplayText(string text)
	{
		textToDisplay=text;
	}
}
