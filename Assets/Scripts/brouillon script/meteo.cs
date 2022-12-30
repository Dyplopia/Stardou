using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meteo : MonoBehaviour
{
   

    //ajouter des particles quand on mettra les assets

    public float chanceOfRain = 80f;
    public float dice;
    public float cycle = 10f;
    public float countTime = 0f;

    public Sprite[] meteoo = new Sprite[2];
    public Image spritemeteo;

    public navetRecolte plansMouiller;

    public void Start()
    {
        spritemeteo = GameObject.Find("SoleilPluie").GetComponent<Image>();
    }

    private void diceThrow() 
    {
        dice = Random.Range(0f, 100.0f);
        if (dice >= chanceOfRain)
        {
            Debug.Log("Il pleut.");
            spritemeteo.sprite = meteoo[1];
            plansMouiller.plan1mouiller = true;
            plansMouiller.plan2mouiller = true;
        }

        else if (dice < chanceOfRain)
        {
            Debug.Log("Il fait soleil.");
            spritemeteo.sprite = meteoo[0];
        }
    }



    // Update is called once per frame
    public void Update()
    {

        countTime += Time.deltaTime; 
        if (countTime >= cycle)
        {
            diceThrow();
            countTime = 0f;
        }
    }
}

