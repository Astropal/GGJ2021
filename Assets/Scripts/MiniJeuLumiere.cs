using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniJeuLumiere : MonoBehaviour
{   
    public int nbIngredients = 0;
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
       if(Col.gameObject.tag == "Ingredient"){
           nbIngredients++;
           Debug.Log(nbIngredients);
       }
       else{
           Debug.Log(nbIngredients);
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
       }

       if(nbIngredients == 2)
       {
           Debug.Log("Gagné !");
       }
    }
    void OnTriggerExit2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Ingredient"){
            nbIngredients--;
            Debug.Log(nbIngredients);
        }
        else{
           Debug.Log(nbIngredients);
       }
    }
}
