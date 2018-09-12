using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Vector3 MoveSpeed;
    public Vector3 RotateSpeed;
    public float Speed;

    public CharacterController Character;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
        MoveSpeed *= Time.deltaTime;


        Character.Move(MoveSpeed);

  
    }
}
