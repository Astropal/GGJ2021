using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Thermo : MonoBehaviour
{

  public int timeout = 1000;
  public bool win = false;

  public GameObject indicatorSize;
  // Start is called before the first frame update
  void Start()
  {
      // win = true;
  }

  // Update is called once per frame
  void Update()
  {
    if(timeout > 0 && win) {
      timeout--;
    }
    if(timeout <= 0) {
        win = false; // Ne pas répéter
        GlobalState.instance.glaceSolved = true;
        GlobalState.instance.glaceExit = true;

        // Mini jeu gagné
        SceneManager.LoadScene("Planets");


    }
  }

  private int elements = 0;

  private void OnTriggerEnter2D(Collider2D Col)
  {
    if (Col.gameObject.tag == "Reservoir")
    {
      elements++;
      Col.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
      GameObject objTemplate = GameObject.FindWithTag("Full_Thermo").transform.Find("Reservoir").gameObject;
      Col.gameObject.transform.position = objTemplate.transform.position;
      Rigidbody2D rb = Col.gameObject.transform.GetComponent<Rigidbody2D>();
      rb.bodyType = RigidbodyType2D.Static;
    }
    if (Col.gameObject.tag == "Reglette")
    {
      elements++;
      Col.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
      GameObject objTemplate = GameObject.FindWithTag("Full_Thermo").transform.Find("Reglette").gameObject;
      Col.gameObject.transform.position = objTemplate.transform.position;
      Rigidbody2D rb = Col.gameObject.transform.GetComponent<Rigidbody2D>();
      rb.bodyType = RigidbodyType2D.Static;
    }
    if (Col.gameObject.tag == "Tube")
    {
      elements++;
      Col.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
      GameObject objTemplate = GameObject.FindWithTag("Full_Thermo").transform.Find("Tube").gameObject;
      Col.gameObject.transform.position = objTemplate.transform.position;
      Rigidbody2D rb = Col.gameObject.transform.GetComponent<Rigidbody2D>();
      rb.bodyType = RigidbodyType2D.Static;
    }
    if (elements == 3)
    {
      Debug.Log("Thermomètre terminé!");
      indicatorSize.transform.localScale =
            new Vector3(indicatorSize.transform.localScale.x,
                4.2f,
                indicatorSize.transform.localScale.z);

      win = true;
    }
  }
}
