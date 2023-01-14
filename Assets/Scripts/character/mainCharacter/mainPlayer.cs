using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayer : MonoBehaviour
{
    public static mainPlayer instance;

    private void Awake() {
        {
            if(instance != null)
            {
                Debug.LogWarning("Il n'y a plus d'une instance de GUIInteract dans la scène");
                return;
            }

            instance = this;
            
    }
    }
}
