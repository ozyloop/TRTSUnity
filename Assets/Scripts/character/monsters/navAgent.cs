using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navAgent : MonoBehaviour
{

    NavMeshAgent agent1;
    private Vector3 position;
    public bool back = false;
    public Animator animator;
    

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
        agent1 = GetComponent<NavMeshAgent>();
        //agent1.destination = new Vector3(5, 0, -15);
        //agent1.destination = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   if(!back)
        {
            agent1.destination = target.transform.position;
        }
        if(TestFirstPos())
        
        {   animator.SetBool("EnterActionZone", false);
            animator.SetBool("ComeBack", true);
            
            gameObject.GetComponent<navAgent>().enabled = false;
            back = false;
        }
        

       
    }

    public void ReplaceMonster()
    {
        back = true;
        
        agent1.destination = position;
    }

    private bool TestFirstPos()
    {
        return (int)gameObject.transform.position.x == (int)position.x && (int)gameObject.transform.position.z == (int)position.z && back;
    }


}