using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetectorCharacterInteractions : MonoBehaviour
{
    public int distance;
   public Dialogue dialogue;
   public bool isInRange=false;
   public bool interacted=false;
   public int sentenceNb;
   public int lenDialogue;

    private void Start() {
        lenDialogue = dialogue.sentences.Length;
    }

   private void Update() 
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E) && !interacted)
        {
            mainPlayer.instance.GetComponent<CharController_Motor>().enabled = false;
                sentenceNb=0;
                TriggerDialogue();
                interacted=  true;
           
            
        }
        else if(sentenceNb == lenDialogue)
        {
            interacted = false;
            mainPlayer.instance.GetComponent<CharController_Motor>().enabled = true;
        }
        else if(interacted && Input.GetMouseButtonDown(0))
        {
            sentenceNb++;
            Debug.Log("test next sentence");
            DialogueManager.instance.DisplayNextSentence();
        }
    }
   

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            GUIInteract.instance.gameObject.SetActive(true);
           //InstanceManagerUI.instance.GetChild(0).SetActive(true);
           isInRange=true;
        }
    }

    
    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {
            GUIInteract.instance.gameObject.SetActive(false);
           isInRange=false;
        }
    }

    void TriggerDialogue()
    {
        DialogueManager.instance.gameObject.SetActive(true);
        DialogueManager.instance.StartDialogue(dialogue);
        interacted= true;
    }
}
