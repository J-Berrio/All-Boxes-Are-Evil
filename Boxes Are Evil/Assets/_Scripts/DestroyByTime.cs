using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;

	void Start ()
    {   if(lifetime > 5)
        {
            gameObject.SetActive(false);
        }
	}

}
