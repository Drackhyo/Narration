----------Cr�� par Alex Plante---------------------


1 Setup de la sc�ne. 
Il faut avoir 3 objets:

Objet repr�sentant le joueur(nomm� Player): avec le script "Playerinf.cs"
Un objet vide (DialogManager dans la sc�ne par d�faut): avec les scripts "DialogManager.cs", "SpeechDB.cs" et "WorldManager.cs"
Un ou plusieurs objets NPCs (tagg�s NPC): avec les scripts "NPC.cs" et un script maison de comportement qui h�rite de "NPCBehaviour.cs"


2 Script de comportement
Le script par d�faut est:

//////////////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class MonScript : NPCBehaviour {
	override protected void Start () {
		base.Start();
	}

	override protected void Tick()
	{
	}
}
////////////////////////////////////////////////////

3 M�thodes disponibles pour le script

SetAnswer(string key, string answer)
	Ajoute une nouvelle r�ponse � la phrase "key", si une r�ponse existe d�j�, celle-ci est remplac� par la nouvelle.

SetEvent(string key, string eventName)
	Ajoute un nouvel �v�nement � la phrase "key", si un �v�nement existe d�j�, celui-ci est remplac� par le nouveau. 
	Il faut ensuite cr��r la m�thode "eventname" dans le script comportemental.
	Cette m�thode sera appell� lorsque la phrase sera utilis� sur le NPC.

RemoveEvent(string key, string eventName)
	Enl�ve l'�v�nement du nom "eventName" li� � la phrase "key". Si aucun n'existe, il retourne "false".

ModifyInventory(string itemName, int amount)
	Ajoute "amount" d'objets "itemName" � l'inventaire du NPC sur lequel le script est et retourne le nombre d'objets dans l'inventaire par la suite. 
	"amount" peut �tre 0 pour simplement savoir le nombre d'objets.
	Si "amount" est n�gatif et qu'il n'y a pas assez d'objets dans l'inventaire, aucune op�ration ne sera faite et -1 sera retourn�.

ModifyPlayerInventory(string itemName, int amount)
	Ajoute "amount" d'objets "itemName" � l'inventaire du joueur et retourne le nombre d'objets dans l'inventaire par la suite. 
	"amount" peut �tre 0 pour simplement savoir le nombre d'objets.
	Si "amount" est n�gatif et qu'il n'y a pas assez d'objets dans l'inventaire, aucune op�ration ne sera faite et -1 sera retourn�.

AddPlayerPhrase(string phrase)
	Ajoute la phrase "phrase" aux phrases disponibles par le joueur.

RemovePlayerPhrase(string phrase)
	Enl�ve la phrase "phrase" aux phrases disponibles par le joueur.


Tick() est appel� � chaque action dans le jeu, tel que contr�l� par "WorldManager.cs"