using UnityEngine;
using System.Collections;



public class GameManager : MonoBehaviour {

	//variable static  qui ne peut exister qu'une fois dans le programme
	private static GameManager gameManager = null;

	// on defini la variable currentLanguage
	private string currentLangage = "en";


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

		//On recupère la langue du jeu dans les playerpref si elle existe et on charge la langue du jeu 

		if (PlayerPrefs.GetString("language") != null && PlayerPrefs.GetString("language") != "")
		{
			currentLangage = PlayerPrefs.GetString("language");
		}

		// On charge les prefs Array
		this.GetComponent<DataManager>().GetParameters();

		// On charge la langue
		GameManager.ChangeLanguage (currentLangage);

		//chargement de menu
#pragma warning disable CS0618 // Type or member is obsolete
		Application.LoadLevel("Menu");
#pragma warning restore CS0618 // Type or member is obsolete
	}

	public static void ChangeLanguage(string language)
	{
		PlayerPrefs.SetString ("language", language);
		gameManager.currentLangage = language;
		gameManager.GetComponent<DataManager> ().GetLocalization (language);
	}

	public static string GetDataLanguage(string id)	
	{		
		string text = "";		
		if (gameManager.GetComponent<DataManager>().localizationDictionnary != null) 
		{			
			if (gameManager.GetComponent<DataManager>().localizationDictionnary.ContainsKey (id)) 
			{				
				text = gameManager.GetComponent<DataManager>().localizationDictionnary [id];	
			}		
		}		
		return text;	
	}

	public static string[] GetDataParametersArray (string id)	
	{
		string[] array = null;		
		if (gameManager.GetComponent<DataManager>().parametersArrayDictionnary != null) 
		{			
			if (gameManager.GetComponent<DataManager>().parametersArrayDictionnary.ContainsKey (id)) 
			{
				array = gameManager.GetComponent<DataManager>().parametersArrayDictionnary[id];	
			}		
		}		
		return array;	
	}

	public static float GetDataParametersFloat(string id)
	{
		float f = 0;
		if (gameManager.GetComponent<DataManager>().parametersFloatDictionnary != null)
		{
			if (gameManager.GetComponent<DataManager>().parametersFloatDictionnary.ContainsKey(id))
			{
				f = gameManager.GetComponent<DataManager>().parametersFloatDictionnary[id];
			}
		}
		return f;
	}
}
