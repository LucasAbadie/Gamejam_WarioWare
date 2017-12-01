using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public Text buttonPlay;
	public Text textPseudo;
	public Text placeHolderEnterName;
	public Text editPseudo;

	void Start()
	{
		getUIMenuText();

		if (PlayerPrefs.GetString("pseudo") != null && PlayerPrefs.GetString("pseudo") != "")
		{
			editPseudo.text = PlayerPrefs.GetString("pseudo");
		}
	}

	public void getUIMenuText()
	{
		try
		{
			buttonPlay.text = GameManager.GetDataLanguage("buttonPlay");
			textPseudo.text = GameManager.GetDataLanguage("textPseudo");
			placeHolderEnterName.text = GameManager.GetDataLanguage("placeHolderEnterName");
		}
		catch
		{
			Debug.LogWarning("GameManager doesn't exist, localisation cannot be found");
		}
	}

	public void ClickButtonLangage(string language)
	{
		try
		{
			GameManager.ChangeLanguage(language);

			//on rafraichit l'UI au cas ou les textes ont changé
			getUIMenuText();
		}
		catch
		{
			Debug.LogWarning("GameManager doesn't exist, localisation cannot be changed");
		}
	}

	public void LaunchSceneGame()
	{
		PlayerPrefs.SetString("Pseudo", editPseudo.text);
		Application.LoadLevel("Opening");
	}
}
