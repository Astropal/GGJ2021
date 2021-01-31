using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thermo : MonoBehaviour
{
  public GameObject indicatorSize;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

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
    }
  }
}
