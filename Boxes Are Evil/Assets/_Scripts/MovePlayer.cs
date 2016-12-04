using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovePlayer : MonoBehaviour
{
    public float speed = 1;
    private CharacterController controller;
    public bool boost;
    public float timer = 5;

    public List<int> ages = new List<int>();

    void Start()
    {
        controller = GetComponent<CharacterController>();
        StaticVar.doSomethingCool();
    }

    void Update()
    {
        float horizontal = speed * Input.GetAxis("Horizontal");
        float vertical = speed * Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        controller.Move(movement * Time.deltaTime);

        //for my random list
        if (Input.GetKeyDown(KeyCode.E))
        {
            ages.Add(Random.Range(1, 100));
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            ages.Remove(ages[Random.Range(0, ages.Count)]);
        }
    }

    void OnTriggerEnter()
    {
        StartCoroutine(SpeedBoost());
        boost = true;
    }

    IEnumerator SpeedBoost()
    {
        while (boost == true)
        {
            timer -= Time.deltaTime;
            speed = 15;
            if (timer <= 0)
            {
                timer = 0;
                speed = 5;
            }
            yield return null;
            //works now, need to redo code later
        }
    }
}
    

