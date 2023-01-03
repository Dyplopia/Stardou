using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrosoir : MonoBehaviour
{
    public bool arroselect = false;

    public scriptableTerre terreselected;
    public Meteo meteoRain;

    public Button buttonautreplante1;
    public Button buttonautreplante2;
    public Button buttonautreplante3;
    public Button buttonautreplante4;

    // Start is called before the first frame update
    void Start()
    {
        meteoRain = GameObject.Find("laMeteo").GetComponent<Meteo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickArrosoir()
    {
        if (arroselect == false)
        {
            Debug.Log("Arrosoir équipé.");
            arroselect = true;
            buttonautreplante1.interactable = false;
            buttonautreplante2.interactable = false;
            buttonautreplante3.interactable = false;
            buttonautreplante4.interactable = false;
        }

        else
        {
            Debug.Log("Arrosoir déséquipé.");
            arroselect = false;
            buttonautreplante1.interactable = true;
            buttonautreplante2.interactable = true;
            buttonautreplante3.interactable = true;
            buttonautreplante4.interactable = true;
        }
    }

    public void tpsArro()
    {
        if (terreselected.planWet == true && meteoRain.isRain == false)
        {
            terreselected.timeWet += 1 * Time.deltaTime;
            if (terreselected.timeWet >= 3)
            {
                terreselected.planWet = false;
                Debug.Log("Le plan a besoin d'eau.");
                terreselected.timeWet = 0;

                //appeler sprite terre mouillé
            }
        }

        else if (meteoRain.isRain == true)
        {
            terreselected.planWet = true;
        }
    }
}
