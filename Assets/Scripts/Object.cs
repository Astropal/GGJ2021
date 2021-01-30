using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
  public string Id = "obj-1";

  public string Name = "OBJECT";

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
    Destroy(gameObject);
  }
}
