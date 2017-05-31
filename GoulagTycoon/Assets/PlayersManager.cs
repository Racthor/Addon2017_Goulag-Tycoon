using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour {

    public GameObject playerBleu;
    public GameObject playerRouge;
    public GameObject playerVert;
    public GameObject hunter;

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    string[] arrayJS;

    // Use this for initialization
    void Start() {
        arrayJS = Input.GetJoystickNames();
    }

    // Update is called once per frame
    void Update() {

    }

    //void OnGUI() {
    //    playerBleu.movingObject();
    //}
}
