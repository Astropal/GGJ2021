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
    Debug.Log("Mouse hover PNJ");
    // if(GlobalState.instance.guiOpen) return;
    ToggleHoverIndicator(true);
  }

  void OnMouseExit()
  {
    // if(GlobalState.instance.guiOpen) return;
    ToggleHoverIndicator(false);
  }

  public void ToggleHoverIndicator(bool toggle)
  {
    Color newColor;
    SpriteRenderer sr = hoverIndicator.GetComponent<SpriteRenderer>();
    newColor = sr.color;
    newColor.a = toggle ? 1f : 0f;
    sr.color = newColor;
  }

}
