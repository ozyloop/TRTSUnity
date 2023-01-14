using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetectorHeal : MonoBehaviour
{
    private bool near = false;


    void Update()
    {
        if(near==true && Input.GetKeyDown(KeyCode.E))
        {
            PlayerManager.instance.playerHealth =100;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            
            //display command to interact
            near = true;
            InstanceManager.instance._GUI_HEAL.SetActive(true);
           
        }
    }

    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {
            near = false;
            InstanceManager.instance._GUI_HEAL.SetActive(false);
           
           
        }
    }
}
