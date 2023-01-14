using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float playerHealth = 100f;

    public static PlayerManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerManager dans la scène");
        }
        instance = this;
    }

    void Update()
    {
        if(playerHealth<=0)
        {
            GameOverManager.instance.OnPlayerDeath();
        }
    }
}
