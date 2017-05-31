using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player1;

    private Vector3 positionInit;

	// Use this for initialization
	void Start () {
        positionInit = player1.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnGUI() {
        Event e = Event.current;
        if ( Input.GetKey( KeyCode.Joystick1Button3 ) ) {
            Debug.Log( "Detected a gamepad event!" );
            player1.transform.position = new Vector3( player1.transform.position.x +1, player1.transform.position.y, player1.transform.position.z );
        }
        if ( Input.GetKey( KeyCode.Joystick1Button4 ) ) {
            Debug.Log( "Detected a gamepad event!" );
            player1.transform.position = positionInit;
        }

    }
}
