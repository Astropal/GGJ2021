using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public GameObject planet;

    public static string alreadyplayed = "n";

    public bool prevIsInside = false;
    public bool isInside = false;

    private void OnTriggerStay2D(Collider2D other) {
       isInside = true;
       if(prevIsInside != isInside) {
           prevIsInside = isInside;
           alreadyplayed = "n";
           OnEnter();
       }
    }

    private void OnTriggerEnter2D() {
        OnEnter();
    }

    private void OnTriggerExit2D(){
        if(GlobalState.instance.guiOpen) return;
        gameObject.transform.Find("PNJS").gameObject.SetActive(false);
        Animation animationP = planet.GetComponent<Animation>();
        animationP["PlanetZoom"].speed = -1;
        animationP["PlanetZoom"].time = animationP["PlanetZoom"].length;
        animationP.Play("PlanetZoom");
        CameraTransition.alreadyplayed = "n";
        GameObject.FindWithTag("Music").gameObject.GetComponent<Audio>().PlaySpace();
    }

    private void OnEnter() {
        if(alreadyplayed == "n"){

            Animation animationP = planet.GetComponent<Animation>();
            animationP["PlanetZoom"].speed = 1;
            animationP.Play("PlanetZoom");
            alreadyplayed = "y";
            gameObject.transform.Find("PNJS").gameObject.SetActive(true);

            GameObject.FindWithTag("Music").gameObject.GetComponent<Audio>().PlayGlace();

        } 
    }
}
