using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Object.DontDestroyOnLoad example.
//
// This script example manages the playing audio. The GameObject with the
// "music" tag is the BackgroundMusic GameObject. The AudioSource has the
// audio attached to the AudioClip.

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        GameObject[] edit = GameObject.FindGameObjectsWithTag("EditorOnly");


        if (players.Length > 1)
        {
            Destroy(gameObject);
        }
        else if(edit.Length > 1){
            Destroy(gameObject);
        }
        /*else if(planets.Length > 1){
            Destroy(gameObject);
        }*/

        DontDestroyOnLoad(gameObject);
    }
}