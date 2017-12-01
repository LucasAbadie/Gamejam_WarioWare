using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
	

	public void LaunchSceneGame()
	{
#pragma warning disable CS0618 // Type or member is obsolete
		Application.LoadLevel("Opening");
#pragma warning restore CS0618 // Type or member is obsolete
	}
}
