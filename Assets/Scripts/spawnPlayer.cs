using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    //public GameObject planetTarget = CameraTransition.planetName;
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    
}
