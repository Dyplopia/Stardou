﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achatPlantes : MonoBehaviour
{
    public int grainelegu1 = 1;
    public int grainelegu2 = 0;
    public int argent = 50;
    public int achatlegu1 = 10;

    public GameObject txt;

    //public Button Legu1Achat;
    //public Button Legu2Achat;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("nbrGraine1");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //        if (argent < achatlegu1)
        //        {
        //            Debug.Log("Pas assez de pesos!");
        //        }
        //        else
        //        {
        //            argent = argent - achatlegu1;
        //            grainelegu1 = grainelegu1 + 1;
        //            Debug.Log("Vous avez acheté une graine de legu1.");
        //        }
        //}
    }
    public void OnClick()
    {
        if (argent < achatlegu1)
        {
            Debug.Log("Pas assez de pesos!");
        }
        else
        {
            argent = argent - achatlegu1;
            grainelegu1 = grainelegu1 + 1;
            Debug.Log("Vous avez acheté une graine de legu1.");
            txt.GetComponent<UnityEngine.UI.Text>().text = grainelegu1.ToString();
        }
    }

    public void OnClick2()
    {
        Debug.Log("Ce légume n'est pas encore disponible.");
    }

    //private void BoutonAchat(Button buttonPressed)
    //{
    //    if (buttonPressed == Legu1Achat)
    //    {
    //        if (argent < achatlegu1)
    //        {
    //            Debug.Log("Pas assez de pesos!");
    //        }
    //        else
    //        {
    //            argent = argent - achatlegu1;
    //            grainelegu1 = grainelegu1 + 1;
    //            Debug.Log("Vous avez acheté une graine de legu1.");
    //        }
    //    }

    //    else if (buttonPressed == Legu2Achat)
    //    {
    //        Debug.Log("Ce légume n'est pas encore disponible.");
    //    }
    //}

}
