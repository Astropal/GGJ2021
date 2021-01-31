using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ : MonoBehaviour
{

  public string Name = "PNJ";
  public bool MiniGameMaster = false;

  public MiniGame miniGame;

  // Start is called before the first frame update
  void Start()
  {

  }

    GameObject[] gui;
  // Update is called once per frame
  void Update()
  {
      gui = GameObject.FindGameObjectsWithTag("Player");
      foreach (var item in gui)
      {
          //Debug.Log(item.name);
      }

  }

  private void OnMouseDown()
  {
          Debug.Log("Open minigame " + GlobalState.instance.guiOpen);

    if(GlobalState.instance.guiOpen) return;
    if (MiniGameMaster)
    {
      gameObject.GetComponent<InteractiveObject>().ToggleHoverIndicator(false);
      Transform parent;
      miniGame.GetComponent<MiniGame>().Show(true);
    }

  }
}
