using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantation : MonoBehaviour
{
    public scriptableTerre terreselected;
    public SelectPlante selection;
    public Arrosoir arrosoirSelect;
    public Magasin argentVente;
    //public Meteo meteoRain;

    public GameObject testing;

    public float timerPlante;

    // Start is called before the first frame update
    void Start()
    {
        terreselected.Initialisation2();
        arrosoirSelect = GameObject.Find("StockdeGraines").GetComponent<Arrosoir>();
        argentVente = GameObject.Find("Store").GetComponent<Magasin>();
        selection.plantselected.planteStagenum = testing.GetComponent<SpriteRenderer>();
        //meteoRain = GameObject.Find("Terrain").GetComponent<Meteo>();
    }

    // Update is called once per frame
    void Update()
    {
        arrosoirSelect.tpsArro();
        isPlanted();
    }
    public void OnMouseDown()
    {
        if (selection.dejaselect == true)
        {
            if (terreselected.usedplan == false)
            {
                Debug.Log(selection.plantselected.planteName + " planté.e.");
                terreselected.usedplan = true;
                selection.plantselected.nbrGraine -= 1;
                selection.plantselected.plantePose = true;
                selection.dejaselect = false;
                selection.buttonarro.interactable = true;
                selection.buttonautreplante1.interactable = true;
                selection.buttonautreplante2.interactable = true;
                selection.buttonautreplante3.interactable = true;
            }

            else if (terreselected.usedplan == true)
            {
                Debug.Log("Le plan est déjà utilisé.");
            }

            //else
            //{
            //    Debug.Log("Vous n'avez pas de graine sélectionnée.");
            //}
        }

        else if (arrosoirSelect.arroselect == true)
        {
            if (terreselected.planWet == false)
            {
                Debug.Log("Le plan est arrosé.");
                //terreselected.spriteTerrenum.sprite = terreselected.spriteTerrain[1];
                terreselected.planWet = true;
                arrosoirSelect.arroselect = false;
                arrosoirSelect.buttonautreplante1.interactable = true;
                arrosoirSelect.buttonautreplante2.interactable = true;
                arrosoirSelect.buttonautreplante3.interactable = true;
                arrosoirSelect.buttonautreplante4.interactable = true;
                Debug.Log("Arrosoir déséquipé.");

                //temps de sol mouillé avant de devoir ré-arroser
                //tpsArro();
                ////temps de croissance de la plante
                //isPlanted();

            }

            else if (arrosoirSelect.arroselect == true && terreselected.planWet == true)
            {
                Debug.Log("Plan déjà arrosé.");
                arrosoirSelect.arroselect = false;
                arrosoirSelect.buttonautreplante1.interactable = true;
                arrosoirSelect.buttonautreplante2.interactable = true;
                arrosoirSelect.buttonautreplante3.interactable = true;
                arrosoirSelect.buttonautreplante4.interactable = true;
            }
        }

        else if (selection.plantselected.planteReady == true)
        {
            RecolteReady();
        }

    }

    public void isPlanted()
    {
        if (selection.plantselected.plantePose == true)
        {
            ////appeler les sprites
            //testing.GetComponent<SpriteRenderer>().sprite = selection.plantselected.planteStagenum;
            selection.plantselected.planteStagenum.sprite = selection.plantselected.planteStages[0];

            if (terreselected.planWet == true)
            {
                timerPlante += 1 * Time.deltaTime;
            }

            if (selection.plantselected.planteStagenum == selection.plantselected.lastSprite())
            {
                Debug.Log("Le.La " + selection.plantselected.planteName + " peut être récolté.e.");
                selection.plantselected.planteReady = true;
                //RecolteReady();
            }
            else if (timerPlante >= selection.plantselected.timeBTWStage)
            {
                for (int i = 0; i < selection.plantselected.planteStages.Length; i++)
                {
                    selection.plantselected.planteStagenum.sprite = selection.plantselected.planteStages[i];
                    timerPlante = 0;
                    Debug.Log("Le.La " + selection.plantselected.planteName + " pousse encore.");
                }
            }

            //else if (timerPlante >= selection.plantselected.timeBTWStage)
            //{
            //    selection.plantselected.planteStagenum = selection.plantselected.planteStages[+1];
            //    testing.GetComponent<SpriteRenderer>().sprite = selection.plantselected.planteStagenum;
            //    timerPlante = 0;
            //    Debug.Log("Le.La " + selection.plantselected.planteName + " pousse encore.");
            //}

            //while (selection.plantselected.planteStagenum != selection.plantselected.planteStages[selection.plantselected.planteStages.Length - 1])
            //{
            //    timerPlante += 1 * Time.deltaTime;
            //    if (timerPlante >= selection.plantselected.timeBTWStage)
            //    {
            //        selection.plantselected.planteStagenum = selection.plantselected.planteStages[+1];
            //        //testing.GetComponent<SpriteRenderer>().sprite = selection.plantselected.planteStagenum;
            //        timerPlante = 0;
            //        Debug.Log("Le.La " + selection.plantselected.planteName + " pousse encore.");
            //    }

            //    else if (selection.plantselected.planteStagenum == selection.plantselected.lastSprite())
            //    {
            //        break;
            //    }
            //    break;
            //}
        }
    }

    //public void tpsArro()
    //{
    //    if (terreselected.planWet == true && meteoRain.isRain == false)
    //    {
    //        terreselected.timeWet += 1 * Time.deltaTime;
    //        if (terreselected.timeWet >= 3)
    //        {
    //            terreselected.planWet = false;
    //            Debug.Log("Le plan a besoin d'eau.");
    //            terreselected.timeWet = 0;

    //            //appeler sprite terre mouillé
    //        }
    //    }

    //    else if (meteoRain.isRain == true)
    //    {
    //        terreselected.planWet = true;
    //    }
    //}

    public void RecolteReady()
    {
        if (/*selection.plantselected.planteReady == true &&*/ arrosoirSelect.arroselect == false)
        {
            selection.plantselected.plantePose = false;
            selection.plantselected.planteReady = false;
            terreselected.usedplan = false;
            argentVente.argent += selection.plantselected.ventePlante;
            Debug.Log("Le.La " + selection.plantselected.planteName + " a été récolté.e. Vous l'avez vendu " + selection.plantselected.ventePlante + " pesos.");
            timerPlante = 0;
        }
    }
}
