using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Planet : MonoBehaviour
{

  public string Name = "Planet";
  public GameObject miniGame;
  private bool Solved = false;

  // Start is called before the first frame update
  void Start()
  {
    // setAlpha(0.5f);
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void setAlpha(float alpha)
  {
    SpriteRenderer[] children = GetComponentsInChildren<SpriteRenderer>();
    Color newColor;
    foreach (SpriteRenderer child in children)
    {
      newColor = child.color;
      newColor.a = alpha;
      child.color = newColor;
    }
  }

  void OnMouseDown()
  {
    Solved = !Solved;
    //setAlpha(Solved ? 1f : 0.5f);
    
   // SceneManager.LoadScene("MiniJeuLumiere");
  }
}
