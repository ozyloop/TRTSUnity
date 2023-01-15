using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Interactions : MonoBehaviour
{
    private bool testFin=false;
    private bool[] discovered = new bool[]{ false,false,false,false,false,false};
    // Update is called once per frame
    void Update()
    {
        ClickItem();
    }

    void ClickItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool victory = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, 50f) && hit.transform.gameObject.CompareTag("Items"))
            {
                int nbIndice = int.Parse(hit.transform.gameObject.name[hit.transform.gameObject.name.Length - 1].ToString());
                
                
                InstanceIndices.instance.gameObject.transform.GetChild(nbIndice).gameObject.SetActive(true);
                discovered[nbIndice]=true;
               
                if(hit.transform.gameObject.GetComponent<DistanceDetectorItem>().toDestroy)
                {
                    hit.transform.gameObject.SetActive(false);
                }
                foreach (bool indice in discovered)
                {
                    if (!indice)
                    victory = false;
                }
 
                if(victory == true) {
                    InstanceManager.instance.VictoryUI.SetActive(true);
                }
                    
                
                
                
                
            }
        }
    }

    
}
