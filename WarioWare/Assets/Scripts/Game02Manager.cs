using UnityEngine;
using System.Collections;

public class Game02Manager : MonoBehaviour {

    public MeshRenderer RefPicture;
    public static Game02Manager instance = null;
    public Material[] materials;

  

    void Start () {
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		}

        instance = this;

        RefPicture.material = materials[Random.Range(0, 2)];
	}

    public void NextLevel()
    {
        Application.LoadLevel("Game03");
    }
	
	void Update () {
	
	}
}
