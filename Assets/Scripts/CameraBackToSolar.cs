using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackToSolar : MonoBehaviour
{
    public Camera mainCam;
    public GameObject planet;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown(){
        // Display children
        gameObject.transform.parent.gameObject.SetActive(false);
        gameObject.transform.parent.parent.gameObject.transform.Find("PNJS").gameObject.SetActive(false);


        Animation animation = mainCam.GetComponent<Animation>();
        string animationName = "CameraMove" + (string) planet.name;
        animation[animationName].speed = -1;
        animation[animationName].time = animation[animationName].length;
        animation.Play(animationName);

        CameraTransition.alreadyplayed = "n";
    }
}
