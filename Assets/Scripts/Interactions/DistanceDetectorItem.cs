using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetectorItem : MonoBehaviour
{
   public int distance;
   public bool toDestroy;
   
   void Start()
   {
        GetComponent<SphereCollider>().radius =  distance;
   }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
           gameObject.GetComponent<Outline>().enabled = true;
           
        }
    }

    
    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {
           gameObject.GetComponent<Outline>().enabled = false;
           
        }
    }
}
