using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarManager : MonoBehaviour
{
    public Image healthBarImage;

    // Update is called once per frame
    void Update()
    {
        healthBarImage.fillAmount =  PlayerManager.instance.playerHealth / 100f;
    }
}
