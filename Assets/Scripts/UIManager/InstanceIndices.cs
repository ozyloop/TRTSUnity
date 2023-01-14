using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceIndices : MonoBehaviour
{
    public bool[] discovered = new bool[6] ;
    public static InstanceIndices instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de InstanceIndices dans la scène");
        }
        instance = this;
        
        gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
        
    }
    
}
