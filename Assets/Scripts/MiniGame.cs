using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void Show(bool state)
  {
    if (!GlobalState.instance.guiOpen && state)
    {
      gameObject.SetActive(true);
      GlobalState.instance.guiOpen = true;
    }
    else if (GlobalState.instance.guiOpen && state)
    {
      return;
    }
    else
    {
      GlobalState.instance.guiOpen = false;
      gameObject.SetActive(false);
    }
  }
}
