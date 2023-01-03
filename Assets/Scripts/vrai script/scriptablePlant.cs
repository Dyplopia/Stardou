using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Plant", menuName = "Plant")]
public class scriptablePlant : ScriptableObject
{
    public int achatPlante;
    public int ventePlante;

    public int nbrGraine;

    public bool planteReady;
    //public bool planteChoisie;
    public bool plantePose;

    public float timeBTWStage;

    public string planteName;

    public Sprite[] planteStages;
    public int currentStage = 0;
    //public int nombreStages = 3;


    public Sprite lastSprite()
    {
        return planteStages[planteStages.Length - 1];
    }

    public SpriteRenderer planteStagenum;
    public Sprite[] planteIcon;

    public void Initialisation()
    {
        nbrGraine = 0;
        planteReady = false;
        plantePose = false;
        //planteChoisie = false;
        planteStagenum = null;
        currentStage = 0;
    }

    public void ResetOnRecolte(){
        currentStage = 0;
        planteReady = false;
        plantePose = false;
    }
}
