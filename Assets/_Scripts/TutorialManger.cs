using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManger : MonoBehaviour
{
    public GameObject[] popups;
    private int popUpIndex;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<popups.Length; i++)
        {
            if(i==popUpIndex)
            {
                popups[popUpIndex].SetActive(true);
            }
            else{
                popups[popUpIndex].SetActive(false);
            }
        }

        if(popUpIndex == 0)
        {
            
        }
    }
}
