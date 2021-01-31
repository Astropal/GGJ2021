using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlaceGame : MonoBehaviour
{
    public int nbIngredients = 0;

    private int nbMg = 0;

    private int nbHgO = 0;

    public GameObject reservoir;

    public GameObject indicator;

    public GameObject indicatorSize;

    public GameObject potion_Mg;

    public GameObject potion_HgO;

    public float initY;

    private bool lost = false;
    private bool win = false;

    private int timeBeforeLost = 500;

    // Start is called before the first frame update
    void Start()
    {
        initY = indicatorSize.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (lost)
        {
            if (timeBeforeLost > 0)
            {
                timeBeforeLost--;
                this.resize(0.41f * nbIngredients);
            }
            else
            {
                if (indicatorSize.transform.localScale.y > 0)
                {
                    this.resize(indicatorSize.transform.localScale.y - 0.002f);
                }
                else
                {
                    SceneManager
                        .LoadScene(SceneManager.GetActiveScene().buildIndex,
                        LoadSceneMode.Single);
                }
            }
        }
        else if(!win)
        {
            this.resize(0.41f * nbIngredients);
        } else {
            // Win

        }
    }

    void resize(float amount)
    {
        indicatorSize.transform.position =
            new Vector3(indicatorSize.transform.position.x,
                initY + (amount / 2),
                indicatorSize.transform.position.z);
        indicatorSize.transform.localScale =
            new Vector3(indicatorSize.transform.localScale.x,
                amount,
                indicatorSize.transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "LiquideGlace" && nbIngredients < 3)
        {
            nbIngredients++;

            if (Col.gameObject.GetComponent<Type>().type == "Mg")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 1.2f;
                newColor.g *= 0.7f;
                sr.color = newColor;
                nbMg++;
            }

            if (Col.gameObject.GetComponent<Type>().type == "HgO")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 0.7f;
                newColor.g *= 1.2f;
                sr.color = newColor;
                nbHgO++;
            }

            if (Col.gameObject.GetComponent<Type>().type == "Astro")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                sr.color = new Color(255, 0, 0, 1);
                nbIngredients = 3;
                this.resize(0.41f * nbIngredients);
                lost = true;
            }

            if (Col.gameObject.GetComponent<Type>().type == "Orange")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 2f;
                newColor.g *= 1.2f;
                newColor.b *= 0.2f;
                sr.color = newColor;
            }

            if (Col.gameObject.GetComponent<Type>().type == "Vert")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 0.2f;
                newColor.g *= 2f;
                newColor.b *= 0.2f;
                sr.color = newColor;
            }

            if (Col.gameObject.GetComponent<Type>().type == "Violet")
            {
                Color newColor;
                SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                newColor = sr.color;
                newColor.r *= 1.2f;
                newColor.g *= 0.2f;
                newColor.b *= 2f;
                sr.color = newColor;
            }

            this.resize(0.41f * nbIngredients);

            Debug.Log (nbIngredients);
            Destroy(Col.gameObject);

            if (nbIngredients == 3)
            {
                if (nbMg == 1 && nbHgO == 2)
                {
                    Debug.Log("Gagné!");
                    SpriteRenderer sr = indicator.GetComponent<SpriteRenderer>();
                    sr.color = new Color(0.6f, 0.1f, 0.1f, 1.0f);
                    reservoir.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    Rigidbody2D rb = reservoir.transform.GetComponent<Rigidbody2D>();
                    rb.AddForce(new Vector2(-3e4f, 5e4f));
                    reservoir.transform.transform.Rotate(0, 0, 10);
                    win = true;
                }
                else
                {
                    Debug.Log("Perdu!");
                    lost = true;
                }
            }
        }
        else
        {
            Debug.Log (nbIngredients);
        }
    }
}
