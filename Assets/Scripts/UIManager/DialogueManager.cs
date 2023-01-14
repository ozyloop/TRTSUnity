using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TMP_Text nameText;
    public TMP_Text dialogueText;

    private Queue<string> sentences;
    public static DialogueManager instance;

    private void Awake() {
        {
            if(instance != null)
            {
                Debug.LogWarning("Il n'y a plus d'une instance de DialogueManager dans la scène");
                return;
            }

            instance = this;

            sentences =  new Queue<string>();
            gameObject.SetActive(false);
    }
        }
    

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.nameCharacter;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text =  sentence;
    }

    void EndDialogue()
    {
        gameObject.SetActive(false);
    }
}
