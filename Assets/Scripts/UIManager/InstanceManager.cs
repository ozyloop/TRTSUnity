using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceManager : MonoBehaviour
{

    public GameObject _GUI_HEAL;
    public GameObject VictoryUI;

    public static InstanceManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerManager dans la scène");
        }
        instance = this;
        
    }
    
}
