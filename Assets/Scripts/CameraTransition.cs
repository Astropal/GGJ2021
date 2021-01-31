using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{

    public Camera mainCam;
    public GameObject planet;

    public static string alreadyplayed = "n";

    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }

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


    private void OnTriggerEnter2D() {

        if(alreadyplayed == "n"){

            Animation animation = mainCam.GetComponent<Animation>();
            Animation animationP = planet.GetComponent<Animation>();
            string animationName = "CameraMove" + (string) planet.name;
            animation[animationName].speed = 1;
            animationP["PlanetZoom"].speed = 1;
            animation.Play(animationName);
            animationP.Play("PlanetZoom");
            alreadyplayed = "y";

            // Display children
            //gameObject.transform.Find("Player").gameObject.SetActive(true);
            gameObject.transform.Find("PNJS").gameObject.SetActive(true);

            GameObject.FindWithTag("Music").gameObject.GetComponent<Audio>().PlayGlace();

        } 
        
    }

    private void OnTriggerExit2D(){
        // if(GlobalState.instance.guiOpen) return;
        
        // Display children
        //gameObject.transform.parent.gameObject.SetActive(false);
        gameObject.transform.Find("PNJS").gameObject.SetActive(false);

        GameObject.FindWithTag("Music").gameObject.GetComponent<Audio>().PlaySpace();

        Animation animationP = planet.GetComponent<Animation>();
        
        Animation animation = mainCam.GetComponent<Animation>();
        string animationName = "CameraMove" + (string) planet.name;
        animation[animationName].speed = -1;
        animation[animationName].time = animation[animationName].length;
        animationP["PlanetZoom"].speed = -1;
        animationP["PlanetZoom"].time = animationP["PlanetZoom"].length;
        animationP.Play("PlanetZoom");
        animation.Play(animationName);

        CameraTransition.alreadyplayed = "n";
    }
}
