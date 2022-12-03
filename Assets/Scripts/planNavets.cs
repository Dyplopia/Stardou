using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planNavets : MonoBehaviour
{
    public GameObject stock;
    public GameObject shop;
    private bool usedplan1 = false;
    private bool usedplan2 = false;

    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("Magasin");
        stock = GameObject.Find("StockGraines");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPlan1()
    {
        if (stock.GetComponent<stockGraine>().selectNavet == true && usedplan1 == false)
        {
            Debug.Log("Navet planté.");
            usedplan1 = true;
            shop.GetComponent<achatPlantes>().grainelegu1 = shop.GetComponent<achatPlantes>().grainelegu1 - 1;
            stock.GetComponent<stockGraine>().OnClickNavet();
            stock.GetComponent<stockGraine>().dejaselect = false;
        }

        else if (stock.GetComponent<stockGraine>().selectNavet == true && usedplan1 == true)
        {
            Debug.Log("Le plan est déjà utilisé.");
        }

        else
        {
            Debug.Log("Vous n'avez pas de graine sélectionnée.");
        }
    }

    public void OnClickPlan2()
    {
        if (stock.GetComponent<stockGraine>().selectNavet == true && usedplan2 == false)
        {
            Debug.Log("Navet planté.");
            usedplan2 = true;
            shop.GetComponent<achatPlantes>().grainelegu1 = shop.GetComponent<achatPlantes>().grainelegu1 - 1;
            stock.GetComponent<stockGraine>().OnClickNavet();
            stock.GetComponent<stockGraine>().dejaselect = false;
        }

        else if (stock.GetComponent<stockGraine>().selectNavet == true && usedplan2 == true)
        {
            Debug.Log("Le plan est déjà utilisé.");
        }

        else
        {
            Debug.Log("Vous n'avez pas de graine sélectionnée.");
        }
    }
}
