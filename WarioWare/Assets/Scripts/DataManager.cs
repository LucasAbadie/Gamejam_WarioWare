using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class DataManager : MonoBehaviour {


	public Dictionary<string, string> localizationDictionnary;
	public Dictionary<string, float> parametersFloatDictionnary;
	public Dictionary<string, string[]> parametersArrayDictionnary;

	public void GetLocalization(string language)
	{
		Debug.Log(language);

		TextAsset localizationText = (TextAsset) Resources.Load(language); 
		XmlDocument xmldoc = new XmlDocument ();
		try {
			xmldoc.LoadXml ( localizationText.text );

		} catch {
			Debug.LogError ("enable to read localization xml");
		} 
		// on vide / initialise le dico
		localizationDictionnary = new Dictionary<string, string> ();
		//Remplissage du dictionnaire avec le xml du dico de verbes
		foreach (XmlNode hudNode in xmldoc.SelectNodes("hud/hudName")) {
			string nameID = hudNode ["name"].InnerText;
			string valueID = hudNode ["value"].InnerText;
			localizationDictionnary.Add (nameID, valueID);
		}
	}

	public void GetParameters()
	{
		TextAsset dataText = (TextAsset)Resources.Load("parameters");
		XmlDocument xmldoc = new XmlDocument();
		try
		{
			xmldoc.LoadXml(dataText.text);

		}
		catch
		{
			Debug.LogError("enable to read parameters xml");
		}
		// on vide / initialise le dico
		parametersFloatDictionnary = new Dictionary<string, float>();
		//Remplissage du dictionnaire avec le xml du dico de verbes
		foreach (XmlNode hudNode in xmldoc.SelectNodes("datas/dataFloat"))
		{
			string nameID = hudNode["name"].InnerText;
			float valueID = float.Parse(hudNode["value"].InnerText);

			parametersFloatDictionnary.Add(nameID, valueID);
		}

		// on vide / initialise le dico
		parametersArrayDictionnary = new Dictionary<string, string[]>();
		//Remplissage du dictionnaire avec le xml du dico de verbes
		foreach (XmlNode hudNode in xmldoc.SelectNodes("datas/dataArray"))
		{
			string nameID = hudNode["name"].InnerText;

			int maxValue = hudNode["values"].ChildNodes.Count;
			string[] values = new string[maxValue];

			for (int i = 0; i < maxValue; i++)
			{
				string valueID = hudNode["values"]["value" + i].InnerText;
				values[i] = valueID;
			}

			parametersArrayDictionnary.Add(nameID, values);
		}
	}
}
