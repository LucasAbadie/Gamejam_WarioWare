using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game02Pictures : MonoBehaviour {

  private void OnMouseDown()
  {
    if (this.GetComponent<MeshRenderer>().material.name == Game02Manager.instance.RefPicture.material.name)
    {
			GameManager.gameManager.globalWin();
		}    
		else
		{
			GameManager.gameManager.globalLose();
		}  
            
  }
}
