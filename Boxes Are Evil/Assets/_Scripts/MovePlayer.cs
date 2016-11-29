using UnityEngine;
using System.Collections;


public class MovePlayer : MonoBehaviour
{
    public float speed = 1;
    private CharacterController controller;
    public bool boost;
    public float timer = 5;
    
   
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

    void OnTriggerEnter()
    {
        StartCoroutine(SpeedBoost());
        boost = true;
    }


    //right now the enemy triggers this
    //but when a star is hit by the player, they'll have a speed boost temporarily
    //this means i'll need a star sometime. 
    //
    //Good thing i've got plenty
    IEnumerator SpeedBoost()
    {
       while(boost = true)
        {
            timer -= Time.deltaTime;
            speed = 15;
            if (timer <= 0)
            {
                timer = 0;
                speed = 5;
            }
            yield return null;
        }
    }
}
