using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ : MonoBehaviour
{

  public string Name = "PNJ";
  public bool MiniGameMaster = false;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnMouseDown()
  {
    if (MiniGameMaster)
    {
      Transform parent;
      parent = transform.parent.parent.Find("MiniGame");
      parent.gameObject.GetComponent<MiniGame>().Show(true);
    }

  }
}
