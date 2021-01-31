using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalState : MonoBehaviour {

    public bool guiOpen = false;
    public static GlobalState instance;
    public Vector3 prevPlayerPos;

    public bool glaceSolved = false;
    
    void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(this);
        }
    }

}