using UnityEngine;
using System.Collections;

public class FadePlayer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Fade());
    }

    //This will access the renderer and make the material fade gradually. 
    //Could use for some 'effect' later on.
    IEnumerator Fade()
    {
        for(float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = f;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
    }
}
