﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PNJ : MonoBehaviour
{

  public string Name = "PNJ";
  public bool MiniGameMaster = false;

  public MenuDialog dialogue;

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
    if(GlobalState.instance.guiOpen || GlobalState.instance.glaceSolved) return;
    DialogueManager.instance.StartDialogue(dialogue);
    if (MiniGameMaster)
    {
      gameObject.GetComponent<InteractiveObject>().ToggleHoverIndicator(false);
      Debug.Log("p: " + GameObject.FindWithTag("Player").transform.Find("Part").transform.position);
      DialogueManager.MiniGameMaster = true;
      DialogueManager.instance.StartDialogue(dialogue);
      GlobalState.instance.prevPlayerPos = GameObject.FindWithTag("Player").transform.Find("Part").transform.position;
      // Transform parent;
      // miniGame.GetComponent<MiniGame>().Show(true);
    } else {
            DialogueManager.MiniGameMaster = false;
    }
  }
}
