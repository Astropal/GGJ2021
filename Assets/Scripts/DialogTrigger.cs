using UnityEngine;

public class DialogTrigger : MonoBehaviour {
    public MenuDialog dialogue;
    public bool test;
    void Update() {

    }

    void OnMouseDown() {
        TriggerDialogue();
    }

    void OnMouseUp() {
        test = false;
    }

    void TriggerDialogue() 
    {
        DialogueManager.instance.StartDialogue(dialogue);
    }
}