using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3 : MonoBehaviour
{
  private int compteur;
	private int nbMaxClick;

  // Use this for initialization
  void Start()
  {
    compteur = 0;
		nbMaxClick = (int)GameManager.GetDataParametersFloat("nbClickSphereGame03");

	}

  // Update is called once per frame
  void Update()
  {

  }

  private void OnMouseDown()
  {
    AudioSource audio = this.GetComponent<AudioSource>();
    audio.Play();

    transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
    compteur++;
		if (compteur >= nbMaxClick && GameManager.gameManager.indexStateGame != 2)
			GameManager.gameManager.globalWin();

  }
}
