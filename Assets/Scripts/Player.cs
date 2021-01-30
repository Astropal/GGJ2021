using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DragTarget dragTarget;
    public Rigidbody2D velocity;

    void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Star")
        {
            dragTarget.Part.transform.position = Col.transform.position;
        }
        else
        {
            dragTarget.m_TargetSpring.enabled = false; 
        }
    }

    void OnTriggerExit2D(Collider2D Col)
    {
        if(Col.gameObject.tag != "Star")
        {
            dragTarget.m_TargetSpring.enabled = true;
        }
        
    }

}
