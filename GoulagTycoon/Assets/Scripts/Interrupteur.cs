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
        Debug.Log("ooo");
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    
    void OnTriggerStay(Collider element)
    {
        Debug.Log("nbJs " + nbJS + " " + Input.GetButtonDown("Joystick 1 Button A") + " " + Input.GetButtonDown("Joystick 2 Button A") + " " + Input.GetButtonDown("Joystick 3 Button A"));
        if (used == false && element.gameObject == player_able && Input.GetButtonDown("Joystick " + nbJS + " Button A"))
        {
            Grille tmp;
            Debug.Log("ooo");
            gameObject.SetActive(false);
            used = true;
            hunter.transform.position = Grille.transform.position;
            tmp = Grille.GetComponent<Grille>();
            tmp.allowed = player_able;
            Debug.Log("ok");
        }
    }
}
