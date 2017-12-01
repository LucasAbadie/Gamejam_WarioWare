using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game02Pictures : MonoBehaviour {
/*  public GameObject PictureA;
    public GameObject PictureB;
    public GameObject PictureC;*/
    //public GameObject RefPicture;

    private void OnMouseDown()
    {
        if (this.GetComponent<MeshRenderer>().material.name == Game02Manager.instance.RefPicture.material.name)
        {
            Debug.Log("Victory");
        }       
            
    }

}
