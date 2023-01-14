using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIInteract : MonoBehaviour
{
    public static GUIInteract instance;

    private void Awake() {
        {
            if(instance != null)
            {
                Debug.LogWarning("Il n'y a plus d'une instance de GUIInteract dans la scène");
                return;
            }

            instance = this;
            gameObject.SetActive(false);
    }
    }
}
