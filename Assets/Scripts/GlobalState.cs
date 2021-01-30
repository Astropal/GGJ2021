using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalState : MonoBehaviour {

    public bool guiOpen = false;
    public static GlobalState instance;
    
    void Awake(){
        if (instance == null){
            instance = this;
            // DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this);
        }
    }

}