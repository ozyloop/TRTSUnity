using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DistanceDetectorMonster : MonoBehaviour
{
   public int distance;
   public Animator animator;
   public bool isInRange =false;
   public bool isInAttackRange;
   
   
   void Start()
   {
        GetComponent<SphereCollider>().radius =  distance;
   }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {Debug.Log("enter");
           gameObject.GetComponent<navAgent>().enabled = true;
           animator.SetBool("EnterActionZone", true);
           animator.SetBool("ComeBack", false);

           if(isInRange)
           {
            gameObject.GetComponent<NavMeshAgent>().isStopped=true;
            animator.SetBool("AttackDistance", true);
            isInAttackRange =true;
           }
           isInRange = true;
        }

    }

    
    public void OnTriggerExit(Collider collision)
    {
       
        if(collision.CompareTag("Player"))
        {Debug.Log("exit");
        //execute retour commande et dans navagent enable false quand arrivé
        if(!isInRange || (isInRange && !isInAttackRange))
        {
            gameObject.GetComponent<navAgent>().ReplaceMonster();
            isInRange=false;
        }
        else if(isInRange)
            {
                gameObject.GetComponent<NavMeshAgent>().isStopped=false;
                animator.SetBool("AttackDistance", false);
                if(isInAttackRange)
                {
                    isInAttackRange =false;
                }
                else
                {
                    isInRange =false;
                }
            }
        
            
             
            
        }
    }
}