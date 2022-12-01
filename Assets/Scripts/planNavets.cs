using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planNavets : MonoBehaviour
{
    public GameObject graine1;
    private bool usedplan1 = false;
    private bool usedplan2 = false;

    // Start is called before the first frame update
    void Start()
    {
        graine1 = GameObject.Find("Magasin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPlan1()
    {
        if (graine1.GetComponent<achatPlantes>().grainelegu1 >= 1 && usedplan1 == false)
        {
            Debug.Log("Navet planté.");
            usedplan1 = true;
            graine1.GetComponent<achatPlantes>().grainelegu1 = graine1.GetComponent<achatPlantes>().grainelegu1 - 1;
        }

        else if (graine1.GetComponent<achatPlantes>().grainelegu1 >= 1 && usedplan1 == true)
        {
            Debug.Log("Le plan est déjà utilisé.");
        }

        else
        {
            Debug.Log("Vous n'avez pas de graines.");
        }
    }

    public void OnClickPlan2()
    {
        if (graine1.GetComponent<achatPlantes>().grainelegu1 >= 1 && usedplan2 == false)
        {
            Debug.Log("Navet planté.");
            usedplan2 = true;
            graine1.GetComponent<achatPlantes>().grainelegu1 = graine1.GetComponent<achatPlantes>().grainelegu1 - 1;
        }

        else if (graine1.GetComponent<achatPlantes>().grainelegu1 >= 1 && usedplan2 == true)
        {
            Debug.Log("Le plan est déjà utilisé.");
        }

        else
        {
            Debug.Log("Vous n'avez pas de graines.");
        }
    }
}
