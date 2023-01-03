using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class achatButton : MonoBehaviour
{
    public GameObject txt;
    public TMP_Text txtMagasin;

    public scriptablePlant plantselected;

    public Magasin argentnbr;

    void Start()
    {
        plantselected.Initialisation();
        textBout();
    }

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<Text>().text = plantselected.planteName + "\n" + plantselected.nbrGraine.ToString();

    }

    public void onClickAchat()
    {

            if (argentnbr.argent < plantselected.achatPlante)
            {
                Debug.Log("Pas assez de pesos!");
            }
            else
            {
                argentnbr.argent = argentnbr.argent - plantselected.achatPlante;
                plantselected.nbrGraine = plantselected.nbrGraine + 1;
                Debug.Log("Vous avez acheté une graine de " + plantselected.planteName);
            }
        
    }

    public void textBout()
    {
        txtMagasin.GetComponent<TextMeshProUGUI>().text = plantselected.planteName + "\n" + plantselected.achatPlante.ToString();
    }

}
