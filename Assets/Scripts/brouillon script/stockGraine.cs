using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stockGraine : MonoBehaviour
{
    public GameObject shop;
    public bool selectNavet = false;
    public bool selectLegu2 = false;
    public bool dejaselect = false;

    public Button buttonarro;

    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("Récolte");
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
            buttonarro.interactable = false;
        }

        else if (dejaselect == true)
        {
            Debug.Log("Graine déselectionnée.");
            selectNavet = false;
            dejaselect = false;
            buttonarro.interactable = true;
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
