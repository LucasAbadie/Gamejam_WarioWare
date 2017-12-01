using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OpeningManager : MonoBehaviour {

	public AudioSource rireWario;
	List<string> listGame = new List<string>()
	{
		"Game01",
		"Game02",
		"Game03",
		"Game04",
		"Game05"
	};

	// Use this for initialization
	void Start () {

		// lancer son rire wario
		rireWario.Play ();

		// recupérer l'index du jeu actuel (le coder, par defaut pour le moment c'est toujours le premier jeu)
		int currentIndex = 0; // stocker cette variable dans le game manager et faire un +1 a chaque fin de jeu, la récupérer a cet endroit
		string currentGame = listGame [currentIndex];

		// Lancer la coroutine qui va lancer le jeu qu'il faut
		StartCoroutine( LaunchGameAfter3Seconds(currentGame));

	
	}

	public IEnumerator LaunchGameAfter3Seconds(string gameName)
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel(gameName);
	}
}
