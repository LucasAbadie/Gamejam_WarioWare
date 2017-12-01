using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OpeningManager : MonoBehaviour {

	public AudioSource rireWario;
	public AudioSource winWario;
	List<string> listGame = new List<string>()
	{
		"Game01",
		"Game02",
		"Game03",
		"Game08"
	};

	public Material[] objectsOpeningMaterials;

	// Use this for initialization
	void Start () {

	// RAZ materials carré information progression
	GameObject objectsOpening = GameObject.Find("ObjectsOpening");
		for (int i = 0; i < objectsOpening.transform.childCount; i++)
		{
			objectsOpening.transform.GetChild(i).GetComponent<MeshRenderer>().material = objectsOpeningMaterials[0];
		}

		for (int i = 0; i < GameManager.gameManager.currentIndex; i++)
		{
			objectsOpening.transform.GetChild(i).GetComponent<MeshRenderer>().material = objectsOpeningMaterials[2];
		}

		if (GameManager.gameManager.indexStateGame == 1)
			objectsOpening.transform.GetChild(GameManager.gameManager.failIndex).GetComponent<MeshRenderer>().material = objectsOpeningMaterials[1];

		// Test fin de jeu
		if (GameManager.gameManager.currentIndex >= listGame.Count)
		{
			rireWario.Play();
			StartCoroutine(WinGameAfter3Seconds());
			return;
		}

		// lancer son rire wario
		rireWario.Play ();

		// recupérer l'index du jeu actuel (le coder, par defaut pour le moment c'est toujours le premier jeu)
		string currentGame = listGame [GameManager.gameManager.currentIndex];

		// Restart Index d'état du jeu
		GameManager.gameManager.indexStateGame = 0;

		// Lancer la coroutine qui va lancer le jeu qu'il faut
		StartCoroutine( LaunchGameAfter3Seconds(currentGame));
	}

	public IEnumerator LaunchGameAfter3Seconds(string gameName)
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel(gameName);
	}

	public IEnumerator WinGameAfter3Seconds()
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel("Menu");
	}
}
