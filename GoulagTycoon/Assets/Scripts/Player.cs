using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

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
            moveDirection = new Vector3( Input.GetAxis( "Horizontal" ), 0, Input.GetAxis( "Vertical" ) );
            moveDirection = transform.TransformDirection( moveDirection );
            moveDirection *= speed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move( moveDirection * Time.deltaTime );
        //Input.GetAxisRaw( "HorizontalRotation" )


        float x = Input.GetAxis("HorizontalRotation") * Time.deltaTime * 150.0f;
        //float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate( 0, x, 0 );
        //transform.Translate( 0, 0, z );
    }
}
