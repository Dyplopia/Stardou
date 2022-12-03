using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stockGraine : MonoBehaviour
{
    public GameObject shop;
    public bool selectNavet = false;
    public bool selectLegu2 = false;
    public bool dejaselect = false;

    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("Magasin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNavet()
    {
        if (shop.GetComponent<achatPlantes>().grainelegu1 >= 1 && dejaselect == false)
        {
            Debug.Log("Graine de navet sélectionnée.");
            selectNavet = true;
            dejaselect = true;
        }

        else if (dejaselect == true)
        {
            Debug.Log("Graine déselectionnée.");
            selectNavet = false;
            dejaselect = false;
        }

        else
        {
            Debug.Log("Vous n'avez pas de graines.");
        }
    }

    public void OnClickLegu2()
    {
        if (shop.GetComponent<achatPlantes>().grainelegu2 >= 1 && dejaselect == false)
        {
            Debug.Log("Graine de legu2 sélectionnée.");
            selectLegu2 = true;
            dejaselect = true;
        }

        else if (dejaselect == true)
        {
            Debug.Log("Graine déselectionnée.");
            selectLegu2 = false;
            dejaselect = false;
        }

        else
        {
            Debug.Log("Vous n'avez pas de graines.");
        }
    }
}
