using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
  public GameObject hoverIndicator;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnMouseEnter()
  {
    ToggleHoverIndicator(true);
  }

  void OnMouseExit()
  {
    ToggleHoverIndicator(false);
  }

  void ToggleHoverIndicator(bool toggle)
  {
    Color newColor;
    SpriteRenderer sr = hoverIndicator.GetComponent<SpriteRenderer>();
    newColor = sr.color;
    newColor.a = toggle ? 1f : 0f;
    sr.color = newColor;
  }

}
