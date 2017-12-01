using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	public Text title;
	public Text chrono;
	private string timerTitle;
	public float gameDuration = 5;
	private float currentTime;

	// Use this for initialization
	void Start () {

		getUIText();

		gameDuration = GameManager.GetDataParametersFloat("timer" + SceneManager.GetActiveScene().name);
		currentTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		// mise à jour du chronomètre, on ne permet pas qu'il descende en dessous de 0
		float timeElapsed = Mathf.Max( 5 - (Time.time - currentTime), 0);
		chrono.text = timerTitle + " " + timeElapsed.ToString("n2");

		if (timeElapsed <= 0) {
			// fin du jeu
		}

		// mise à jour du fade out du texte
		title.color = Color.Lerp ( title.color, Color.clear, Mathf.Pow(((Time.time - currentTime)/2f ), 4));
	
	}

	public void getUIText()
	{
		try
		{
			title.text = GameManager.GetDataLanguage("title" + SceneManager.GetActiveScene().name);
			timerTitle = GameManager.GetDataLanguage("time");
		}
		catch
		{
			Debug.LogWarning("GameManager doesn't exist, localisation cannot be found");
		}
	}
}
