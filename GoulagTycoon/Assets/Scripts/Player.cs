using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int nbJS;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnGUI() {
        CharacterController controller = GetComponent<CharacterController>();
        if ( controller.isGrounded ) {
            moveDirection = new Vector3( Input.GetAxis( "Joystick " + nbJS + " Axe X" ), -Input.GetAxis( "Joystick " + nbJS + " Axe Y" ), 0 );
            moveDirection = transform.TransformDirection( moveDirection );
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move( moveDirection * Time.deltaTime );
        
        if( Input.GetButton( "Jump" ) ) {
            Debug.Log( "Je saute !" );
        }

        float x = Input.GetAxis("Joystick " + nbJS + " Rotation Y") * Time.deltaTime * 150.0f;

        transform.Rotate( 0, 0, x );
    }
}
