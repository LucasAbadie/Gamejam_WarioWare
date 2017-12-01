using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game08Manager : MonoBehaviour {

	public Text writingWord;
	public InputField inputText;
	public Text inputTextPlaceholder;

	private string[] arrayString;

	// Use this for initialization
	void Start () {

		arrayString = GameManager.GetDataParametersArray("arrayWritingWordGame08");

		Debug.Log(arrayString);

		writingWord.text = arrayString[Random.Range(0, 9)];

		inputTextPlaceholder.text = GameManager.GetDataLanguage("inputTextPlaceholderGame08");

		inputText.Select();
		inputText.ActivateInputField();

	}
 
	
	// Update is called once per frame
	void Update () {
		if (writingWord.text == inputText.text)
			Debug.Log("OK");
	}
}
