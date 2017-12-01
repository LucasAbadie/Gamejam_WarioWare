using UnityEngine;
using System.Collections;

public class Game01Manager : MonoBehaviour {
  public static Game01Manager instance = null;
    
  // Use this for initialization
  void Start () {

    if (instance != null && instance != this)
    {
        Destroy(this.gameObject);
    }
    else
    {
        // pour qu'on puisse y accéder dans les methodes statiques
        instance = this;
    }
        
  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
