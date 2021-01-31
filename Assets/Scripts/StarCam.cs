using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCam : MonoBehaviour
{
    public GameObject Part;
    public GameObject Camera;
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
        Camera.transform.position = new Vector3(Part.transform.position.x, Part.transform.position.y, -15);
    }
}
