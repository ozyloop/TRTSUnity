using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        ClickItem();
    }

    void ClickItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 5.0f) && hit.transform.gameObject.CompareTag("Items"))
            {
                int nbIndice = int.Parse(hit.transform.gameObject.name[hit.transform.gameObject.name.Length - 1].ToString());
                
                InstanceIndices.instance.discovered[nbIndice] = true;
                InstanceIndices.instance.gameObject.transform.GetChild(nbIndice).gameObject.SetActive(true);
                hit.transform.gameObject.SetActive(false);
                
            }
        }
    }

    
}
