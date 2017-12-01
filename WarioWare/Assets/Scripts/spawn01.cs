using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn01 : MonoBehaviour {
    public float x, y, z;
    public GameObject Cube, Sphere;
    public int nbSphere;
	// Use this for initialization
	void Start () {
        for (int i=0; i< nbSphere; i++)
        {
            spawnRand(Sphere);

        }
        spawnRand(Cube);
		
	}
	public void spawnRand(GameObject ObjectSpawn)
    {
        Vector3 Pos = this.transform.position;
        Pos.x += Random.Range(-x, x);
        Pos.y += Random.Range(-x, x);
        Pos.z += Random.Range(-x, x);
        Instantiate(ObjectSpawn, Pos, Quaternion.identity);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
