using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
           Debug.Log("enter");
           
        }
    }

    
    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {
           Debug.Log("exit");
           
        }
    }
}
