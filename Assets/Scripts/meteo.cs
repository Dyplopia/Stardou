using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meteo : MonoBehaviour
{
   

    //ajouter des particles quand on mettra les assets

    public float chanceOfRain = 50f;
    public float dice;
    public float cycle = 6f;

    public Sprite[] meteoo = new Sprite[2];

    public navetRecolte plansMouiller;

    public void Start()
    {

    }

    IEnumerator diceThrow() 
    {
        yield return new WaitForSeconds(cycle);
        dice = Random.Range(0f, 100.0f);

    }



    // Update is called once per frame
    public void Update()
    {
        StartCoroutine(diceThrow());

        if (dice >= chanceOfRain)
        {
            Debug.Log("Il pleut.");
            plansMouiller.plan1mouiller = true;
            plansMouiller.plan2mouiller = true;
            //meteoo.GetComponent<Image>().color = Color.blue;
        }

        else if (dice < chanceOfRain)
        {
            Debug.Log("Il fait soleil.");
            //meteoo.GetComponent<Image>().color = Color.yellow;
        }

    }
}

