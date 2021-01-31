using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Planet : MonoBehaviour
{

  public string Name = "Planet";
  public GameObject miniGame;
  public bool Solved = false;
  public bool prevSolved = false;

  private void Awake() {
    // DontDestroyOnLoad(gameObject);
  }
  // Start is called before the first frame update
  void Start()
  {
    // setAlpha(0.5f);
  }

  // Update is called once per frame
  void Update()
  {
    if(Solved != prevSolved && Solved) {
      Debug.Log("Prev pos backup " + GlobalState.instance.prevPlayerPos);
      GameObject.FindWithTag("Player").transform.Find("Part").transform.position = GlobalState.instance.prevPlayerPos;
      prevSolved = Solved;
    }
    if(GlobalState.instance.glaceSolved) {
      Solved = true;
      setAlpha(0.2f);
    }
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
    // Solved = !Solved;
    //setAlpha(Solved ? 1f : 0.5f);
    
   // SceneManager.LoadScene("MiniJeuLumiere");
  }
}
