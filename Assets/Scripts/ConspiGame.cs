
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConspiGame : MonoBehaviour
{
    public int nbOutils = 0;

    public GameObject cadreDialogue;

    List<GameObject> listOfObject = new List<GameObject>(); 
    public static bool isSuccessful;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(listOfObject.Count == 3){
            Debug.Log("Bag Full !");
            foreach (var item in listOfObject)
            {
                    if(item.tag == "Camera"){
                        isSuccessful = true;

                    }
                    else
                    {
                        
                        isSuccessful = false;
                    }
                    
            }

            if(isSuccessful) Debug.Log("You could had take a picture :)");

            SceneManager.LoadScene("Planets");

        }

    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Arme"){
           nbOutils++;
           listOfObject.Add(Col.gameObject);
           Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Ligth"){
           nbOutils++;
           listOfObject.Add(Col.gameObject);
           Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Rope"){
           nbOutils++;
           listOfObject.Add(Col.gameObject);
           Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Food"){
           nbOutils++;
           listOfObject.Add(Col.gameObject);
           Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Camera"){
           nbOutils++;
           listOfObject.Add(Col.gameObject);
           Debug.Log(nbOutils);
        }



    }
    void OnTriggerExit2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Arme"){
            nbOutils--;
            listOfObject.Remove(Col.gameObject);
            Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Ligth"){
            nbOutils--;
            listOfObject.Remove(Col.gameObject);
            Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Rope"){
            nbOutils--;
            listOfObject.Remove(Col.gameObject);
            Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Camera"){
            nbOutils--;
            listOfObject.Remove(Col.gameObject);
            Debug.Log(nbOutils);
        }
        if(Col.gameObject.tag == "Food"){
            nbOutils--;
            listOfObject.Remove(Col.gameObject);
            Debug.Log(nbOutils);
        }
    }
}
