using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public GameObject planet;

    public static string alreadyplayed = "n";


    private void OnTriggerEnter2D() {

        if(alreadyplayed == "n"){

            Animation animationP = planet.GetComponent<Animation>();
            animationP["PlanetZoom"].speed = 1;
            animationP.Play("PlanetZoom");
            alreadyplayed = "y";
            gameObject.transform.Find("PNJS").gameObject.SetActive(true);
        } 
        
    }

    private void OnTriggerExit2D(){
        if(GlobalState.instance.guiOpen) return;
        gameObject.transform.Find("PNJS").gameObject.SetActive(false);
        Animation animationP = planet.GetComponent<Animation>();
        animationP["PlanetZoom"].speed = -1;
        animationP["PlanetZoom"].time = animationP["PlanetZoom"].length;
        animationP.Play("PlanetZoom");
        CameraTransition.alreadyplayed = "n";
    }
}
