using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DragTarget dragTarget;
    public Rigidbody2D velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Star")
        {
            dragTarget.Part.transform.position = Col.transform.position;
        }
        else
        {
            dragTarget.m_TargetSpring.enabled = false;
            Debug.Log("Entré !");  
        }
    }

    void OnTriggerExit2D(Collider2D Col)
    {
        if(Col.gameObject.tag != "Star")
        {
            dragTarget.m_TargetSpring.enabled = true;
            Debug.Log("Sorti !");
        }
        
    }

}
