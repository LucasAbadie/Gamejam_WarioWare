using UnityEngine;
using System.Collections;

public class Game01Manager : MonoBehaviour {
    public static Game01Manager instance = null;
    public Sprite GreenCircle;
    public Sprite RedCircle;
    public GameObject lampe;
    
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

    public void Win()
    {
        Debug.Log("Win");
        AudioSource[] audio = this.GetComponents<AudioSource>();
        Debug.Log(audio);
        audio[1].Play();
        lampe.GetComponent<SpriteRenderer>().sprite = GreenCircle;
    }
    public void Lose()
    {
        Debug.Log("Lose");
        AudioSource[] audio = this.GetComponents<AudioSource>();
        audio[0].Play();
        lampe.GetComponent<SpriteRenderer>().sprite = RedCircle;
    }
}
