using UnityEngine;
using System.Collections;



public class GameManager : MonoBehaviour {

	//variable static  qui ne peut exister qu'une fois dans le programme
	private static GameManager gameManager = null;

	// Use this for initialization
	void Start () {

		//SAFE CODE : Check si il existe un autre gamemanager si c'est le cas, je m'autodetruit
		if (gameManager != null && gameManager != this) {
			Destroy (this.gameObject);
			return;
		}

		// pour qu'on puisse y accéder dans les methodes statiques
		gameManager = this;

		// L'objet n'est pas détruit quand on change de scène
		DontDestroyOnLoad (this.gameObject);

		//chargement de menu
		Application.LoadLevel("Menu");
	}

}
