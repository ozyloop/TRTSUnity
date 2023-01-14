using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetectorDoor : MonoBehaviour
{
    public int distance;
    public Animator animator;
   
   void Start()
   {
        GetComponent<SphereCollider>().radius =  distance;
   }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
           animator.SetBool("character_nearby", true);
           
        }
    }

    
    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {
           animator.SetBool("character_nearby", false);
           
        }
    }
}
