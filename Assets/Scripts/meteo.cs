using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
   

    //ajouter des particles quand on mettra les assets

    public float chanceOfRain = 50f;
    public float dice;
    public float cycle = 4.0f;
 

   
    public void Start()
    {
        
    }

    IEnumerator soleil() 
    {
        Debug.Log("Il fait soleil.");
        yield return new WaitForSeconds(cycle);
    }

    IEnumerator pluie()
    {
        Debug.Log("Il pleut.");
        yield return new WaitForSeconds(cycle);
    }

    // Update is called once per frame
    public void Update()
    {
    dice = Random.Range(0f, 100.0f);

        if (dice >= chanceOfRain)
        {
            StartCoroutine(pluie());
            StopCoroutine(pluie());
        }

        else if (dice < chanceOfRain)
        {
            StartCoroutine(soleil());
            StopCoroutine(soleil());
        }
    }
} 

