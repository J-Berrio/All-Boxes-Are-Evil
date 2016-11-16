using UnityEngine;
using System.Collections;


public class MovePlayer : MonoBehaviour
{
    public float speed = 1;
    private CharacterController controller;
   
	void Start ()
    {
        controller = GetComponent<CharacterController>();
	}

	void Update ()
    {
        //keyboard input for up/down, left/right
        float horizontal = speed * Input.GetAxis("Horizontal");
        float vertical = speed * Input.GetAxis("Vertical");

        //actual character controller movement
        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        controller.Move (movement * Time.deltaTime);
	}
}
