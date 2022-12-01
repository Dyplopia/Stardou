using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
   

    //ajouter des particles quand on mettra les assets

    public float chanceOfRain = 50f;
    public float dice;
    public bool soleil;
    public float timer = 0f;

    // Update is called once per frame
    public void Update()
    {
        dice = Random.Range(0f, 100.0f);

        if (dice<chanceOfRain) 
        {
            {
                soleil = true;
                System.Console.WriteLine("Il fait soleil.");
                timer = Random.Range(5f, 20f);
            }
        }
        
        if(soleil)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f) 
            {
                soleil = false;
                System.Console.WriteLine("Il pleut.");
            }
        }
    } 
}
