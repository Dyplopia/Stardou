using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New terrain", menuName = "Terre")]
public class scriptableTerre : ScriptableObject
{
    public bool usedplan;

    public Sprite[] spriteTerrain;
    public SpriteRenderer spriteTerrenum;

    public bool planWet;

    public float timeWet;

    public void Initialisation2()
    {
        usedplan = false;
        planWet = false;
        timeWet = 0;
    }
}
