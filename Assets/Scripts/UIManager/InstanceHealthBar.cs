using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceHealthBar : MonoBehaviour
{
    public static InstanceHealthBar instance;

    private void Awake() {
        {
            if(instance != null)
            {
                Debug.LogWarning("Il n'y a plus d'une instance de InstanceHealthBar dans la scène");
                return;
            }

            instance = this;
            gameObject.SetActive(false);
            
            
    }
    }
}
