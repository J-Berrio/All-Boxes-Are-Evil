using UnityEngine;
using System.Collections;

public class ScorePraise : MonoBehaviour
{
    delegate void Multidelegate();
    Multidelegate highScores;

    //So one day, this will be rearranged so that in the game, when you
    //reach 100 points, 200 points, etc you get PRAISE
    //Right now its  set at 100 points because currently there's no way to gain
    //points, so 100 seems pretty good
    void Start()
    {
        highScores += FirstHighScore;
        highScores += Fireworks;

        if(highScores != null)
        {
            highScores();
        }
    }

    void FirstHighScore()
    {
        print("Yay! You've reached 100 points!");
    }

    void Fireworks()
    {
        //some VFX crap that i dont have right now
        print("VFX! Whooo! Pew pew pew pew! Whooooosh!");
    }

}
