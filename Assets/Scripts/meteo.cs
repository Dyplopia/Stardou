using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
   

    //ajouter des particles quand on mettra les assets

    public float chanceOfRain = 50f;
    public float dice;
    public float cycle = 6f;

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
        }

        else if (dice < chanceOfRain)
        {
            Debug.Log("Il fait soleil.");
        }

    }
}

