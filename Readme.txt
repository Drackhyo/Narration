----------Créé par Alex Plante---------------------


1 Setup de la scène. 
Il faut avoir 3 objets:

Objet représentant le joueur(nommé Player): avec le script "Playerinf.cs"
Un objet vide (DialogManager dans la scène par défaut): avec les scripts "DialogManager.cs", "SpeechDB.cs" et "WorldManager.cs"
Un ou plusieurs objets NPCs (taggés NPC): avec les scripts "NPC.cs" et un script maison de comportement qui hérite de "NPCBehaviour.cs"


2 Script de comportement
Le script par défaut est:

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

3 Méthodes disponibles pour le script

SetAnswer(string key, string answer)
	Ajoute une nouvelle réponse à la phrase "key", si une réponse existe déjà, celle-ci est remplacé par la nouvelle.

SetEvent(string key, string eventName)
	Ajoute un nouvel événement à la phrase "key", si un événement existe déjà, celui-ci est remplacé par le nouveau. 
	Il faut ensuite créér la méthode "eventname" dans le script comportemental.
	Cette méthode sera appellé lorsque la phrase sera utilisé sur le NPC.

RemoveEvent(string key, string eventName)
	Enlève l'évènement du nom "eventName" lié à la phrase "key". Si aucun n'existe, il retourne "false".

ModifyInventory(string itemName, int amount)
	Ajoute "amount" d'objets "itemName" à l'inventaire du NPC sur lequel le script est et retourne le nombre d'objets dans l'inventaire par la suite. 
	"amount" peut être 0 pour simplement savoir le nombre d'objets.
	Si "amount" est négatif et qu'il n'y a pas assez d'objets dans l'inventaire, aucune opération ne sera faite et -1 sera retourné.

ModifyPlayerInventory(string itemName, int amount)
	Ajoute "amount" d'objets "itemName" à l'inventaire du joueur et retourne le nombre d'objets dans l'inventaire par la suite. 
	"amount" peut être 0 pour simplement savoir le nombre d'objets.
	Si "amount" est négatif et qu'il n'y a pas assez d'objets dans l'inventaire, aucune opération ne sera faite et -1 sera retourné.

AddPlayerPhrase(string phrase)
	Ajoute la phrase "phrase" aux phrases disponibles par le joueur.

RemovePlayerPhrase(string phrase)
	Enlève la phrase "phrase" aux phrases disponibles par le joueur.


Tick() est appelé à chaque action dans le jeu, tel que contrôlé par "WorldManager.cs"