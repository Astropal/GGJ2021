using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DragTarget dragTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        dragTarget.m_TargetSpring.enabled = false;
        Debug.Log("Entré !");
    }

    void OnTriggerExit2D()
    {
        dragTarget.m_TargetSpring.enabled = true;
        dragTarget.Player.transform.position = dragTarget.Part.transform.position;
        Debug.Log("Sorti !");
    }

}
