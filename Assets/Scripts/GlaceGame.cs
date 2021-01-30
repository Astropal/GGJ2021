using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlaceGame : MonoBehaviour
{
    public int nbIngredients = 0;
    private int nbMg = 0;
    private int nbHgO = 0;
    public GameObject indicator;
    public GameObject indicatorSize;

    public GameObject potion_Mg;
    public GameObject potion_HgO;

    private bool lost = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(lost) {
            if(indicatorSize.transform.localScale.y > 0) {
                indicatorSize.transform.localScale = new Vector2(indicatorSize.transform.localScale.x, indicatorSize.transform.localScale.y - 0.002f);
            } else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
            }
        } else {
            indicatorSize.transform.localScale = new Vector2(indicatorSize.transform.localScale.x, 0.2f * nbIngredients);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
       if(Col.gameObject.tag == "LiquideGlace" && nbIngredients < 3) {
           nbIngredients++;

           if(Col.gameObject.GetComponent<Type>().type == "Mg") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 1.2f;
                newColor.g *= 0.7f;
                sr.color = newColor;
                nbMg++;
           }

           if(Col.gameObject.GetComponent<Type>().type == "HgO") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 0.7f;
                newColor.g *= 1.2f;
                sr.color = newColor;
                nbHgO++;
           }

           if(Col.gameObject.GetComponent<Type>().type == "Astro") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                sr.color = new Color(255, 0, 0, 1);
                nbIngredients = 4;
                indicatorSize.transform.localScale = new Vector2(indicatorSize.transform.localScale.x, 0.2f * nbIngredients);
                lost = true;
           }

           if(Col.gameObject.GetComponent<Type>().type == "Orange") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 2f;
                newColor.g *= 1.2f;
                newColor.b *= 0.2f;
                sr.color = newColor;
           }

           if(Col.gameObject.GetComponent<Type>().type == "Vert") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 0.2f;
                newColor.g *= 2f;
                newColor.b *= 0.2f;
                sr.color = newColor;
           }

           if(Col.gameObject.GetComponent<Type>().type == "Violet") {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 1.2f;
                newColor.g *= 0.2f;
                newColor.b *= 2f;
                sr.color = newColor;
           }

           Debug.Log(nbIngredients);
           Destroy(Col.gameObject);

           if(nbIngredients == 3) {
               if(nbMg == 1 && nbHgO == 2) {
                   Debug.Log("Gagné!");
               } else {
                   Debug.Log("Perdu!");
                   lost = true;
               }
           }
       }
       else {
           Debug.Log(nbIngredients);
       }

       if(nbIngredients == 2)
       {
           Debug.Log("Gagné !");
       }
    }

}