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
	    nbJS = player_able.GetComponent<Player>().nbJS;
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    
    void OnTriggerStay(Collider element)
    {
        Debug.Log("nbJs " + nbJS + " " + Input.GetButtonDown("Joystick 1 Button A") + " " + Input.GetButtonDown("Joystick 2 Button A") + " " + Input.GetButtonDown("Joystick 3 Button A"));
        if (element.gameObject == player_able && used == false && Input.GetButtonDown("Joystick " + nbJS + " Button A"))
        {
            Debug.Log("ooo");
            used = true;
            hunter.transform.position = Grille.transform.position;

        }
    }
}
