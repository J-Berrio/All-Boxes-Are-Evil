using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    public float speed = 1;
    private Vector3 playerPos;
    private CharacterController controller;
	
	void Start ()
    {
        controller = GetComponent<CharacterController>();
	}
	
	
	void Update ()
    {
        float horizontal = speed * Input.GetAxis("Horizontal");
        float vertical = speed * Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        controller.Move (movement * Time.deltaTime);
	}
}
