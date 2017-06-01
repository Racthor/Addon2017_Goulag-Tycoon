using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public Vector3 posx;
    public GameObject player_able;
    public GameObject hunter;
    public GameObject Zone;
    public GameObject Grille;

    private bool used = false;
    private bool accept = false;
    private int nbJS;
 
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    
    void OnTriggerStay(Collider element)
    {
        nbJS = player_able.GetComponent<Player>().nbJS;
        if (used == false && element.gameObject == player_able && Input.GetButtonDown("Joystick " + nbJS + " Button A"))
        {
            Grille tmp;
            gameObject.SetActive(false);
            used = true;
            hunter.transform.position = Grille.transform.position;
            
            Destroy(Grille);
        }
    }
}
