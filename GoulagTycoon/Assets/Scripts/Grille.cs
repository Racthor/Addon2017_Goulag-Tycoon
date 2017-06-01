using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grille : MonoBehaviour {

    public GameObject allowed;
    private GameObject hunter;

	// Use this for initialization
	void Start ()
    {
        hunter = GameObject.Find("Hunter");
        allowed = null;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == hunter || col.gameObject == allowed)
        {
            Physics.IgnoreCollision(col.gameObject.GetComponent<Collider>(), col.gameObject.GetComponent<Collider>());
        }
    }
}
