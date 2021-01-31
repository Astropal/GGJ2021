using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
   public Text playerNameText;
   public Text npcNameText;
   public Text dialogueText;

   public Animator animator;

   public bool StrartMinigameGlace = false;

   private Queue<string> sentences;
   public static DialogueManager instance;
   private void Awake()
   {
       if(instance != null) {
           Debug.LogWarning("Il y a plus d'une instance de dialogue lancée !");
       }

       instance = this;
       sentences = new Queue<string>();
   }

   public void StartDialogue(MenuDialog dialogue) {
       animator.SetBool("isOpen", true);
       playerNameText.text = dialogue.PlayerName;
       npcNameText.text = dialogue.NPCName;
       sentences.Clear();

       foreach (string sentence in dialogue.sentences)
       {
           sentences.Enqueue(sentence);
       }

       DisplayNextSentence();
   }

   public void DisplayNextSentence()
   {
       if(sentences.Count == 0) {
           EndDialogue();
           return;
       }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

   }

   IEnumerator TypeSentence(string sentence) {
       dialogueText.text = "";
       foreach (char letter in sentence.ToCharArray())
       {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.015f);         
       }
   }

   void EndDialogue() {
       animator.SetBool("isOpen", false);
       if(StrartMinigameGlace) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
       }
   }
}
