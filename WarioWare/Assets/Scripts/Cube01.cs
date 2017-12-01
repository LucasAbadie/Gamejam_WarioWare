using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube01 : MonoBehaviour {
    public AudioClip WinShort;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }



    void OnMouseDown()
    {

        Game01Manager.instance.Win();
        
    }
    
    
}

