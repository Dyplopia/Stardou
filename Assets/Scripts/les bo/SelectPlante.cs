using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlante : MonoBehaviour
{
    public scriptablePlant plantselected;

    public bool dejaselect = false;

    public Button buttonarro;
    public Button buttonautreplante1;
    public Button buttonautreplante2;
    public Button buttonautreplante3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickGraine()
        //voir si rendre mieux le select (voir avec couleur)
    {
        if (plantselected.nbrGraine >= 1 && dejaselect == false)
        {
            Debug.Log("Graine de " + plantselected.planteName + " sélectionnée.");
            //plantselected.planteChoisie = true;
            dejaselect = true;
            buttonarro.interactable = false;
            buttonautreplante1.interactable = false;
            buttonautreplante2.interactable = false;
            buttonautreplante3.interactable = false;
            
        }

        else if (dejaselect == true)
        {
            Debug.Log("Graine déselectionnée.");
            //plantselected.planteChoisie = false;
            dejaselect = false;
            buttonarro.interactable = true;
            buttonautreplante1.interactable = true;
            buttonautreplante2.interactable = true;
            buttonautreplante3.interactable = true;
        }

        else
        {
            Debug.Log("Vous n'avez pas de graines.");
        }
    }
}
