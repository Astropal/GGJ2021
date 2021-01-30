using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public Camera mainCam;
    public GameObject planet;

    public static string alreadyplayed = "n";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if(planetClicked == "y"){
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, -100);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
            mainCam.transform.position = smoothedPosition;
        }*/
        
    }


    private void OnTriggerEnter2D(Collider2D Col) {
        if(Col.gameObject.tag == "Player")
        {
            if(alreadyplayed == "n"){

                Animation animation = mainCam.GetComponent<Animation>();
                string animationName = "CameraMove" + (string) planet.name;
                animation[animationName].speed = 1;
                animation.Play(animationName);
                alreadyplayed = "y";

                // Display children
                //gameObject.transform.Find("Player").gameObject.SetActive(true);
                gameObject.transform.Find("PNJS").gameObject.SetActive(true);
            } 
        }
    }
}
