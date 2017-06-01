using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grille : MonoBehaviour {
    
    private GameObject hunter;

	// Use this for initialization
	void Start ()
    {
        hunter = GameObject.Find("JoueurBleu");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    void OnCollisionStay(Collision col)
    {
        Debug.Log("ok");
        if (col.gameObject == hunter)
        {
            Physics.IgnoreCollision(col.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }
        GameObject.Destroy(gameObject);

    }
}
