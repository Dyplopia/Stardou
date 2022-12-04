using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class navetRecolte : MonoBehaviour
{
    public GameObject stock;
    public int money;
    public bool arroselect = false;
    public bool plan;
    private bool planmouiller = false;
    float timemouiller = 3f;
    float timer = 0f;
    bool navetReady = false;
    public Image[] _stageNavet = new Image[3];

    // Start is called before the first frame update
    void Start()
    {
        plan = GetComponent<planNavets>().usedplan1;
        //plan = GetComponent<planNavets>().usedplan2;
        money = GetComponent<achatPlantes>().argent;
        stock = GameObject.Find("StockGraines");
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
        }

        else
        {
            Debug.Log("Arrosoir déséquipé.");
            arroselect = false;
        }
    }

    public void OnClickArroser()
    {
        //if (stock.GetComponent<stockGraine>().selectNavet == false)
        //{
            if (arroselect == true && planmouiller == false)
            {
                Debug.Log("Le plan est arrosé.");
                planmouiller = true;
                arroselect = false;
                Debug.Log("Arrosoir déséquipé.");

            //timemouiller pour re-arroser
        }

            else if (arroselect == true && planmouiller == true)
            {
                Debug.Log("Plan déjà arrosé.");
            }
        //}
    }

    public void NavetGrowth()
    {
        if (plan == true)
        {
            Debug.Log("plan utilisé");

            if (planmouiller == true)
            {
                timer += 1 * Time.deltaTime;
                if (timer >= 2)
                {
                    GameObject.Find("navetS1").SetActive(true);
                    Debug.Log("Le navet a grandit.");
                }

                if (timer >= 4)
                {
                    GameObject.Find("navetS1").SetActive(false);
                    GameObject.Find("navetS2").SetActive(true);
                    Debug.Log("Le navet pousse encore.");
                }

                if (timer >= 6)
                {
                    GameObject.Find("navetS2").SetActive(false);
                    GameObject.Find("navetS3").SetActive(true);
                    navetReady = true;
                    Debug.Log("Le navet peut être récolté.");
                }
            }
        }
    }

    public void OnclickRecolte()
    {
        if (navetReady == true)
        {
            GameObject.Find("navetS3").SetActive(false);
            navetReady = false;
            plan = false;
            money += 20;
            Debug.Log("Le navet a été récolté. Vous l'avez vendu 20 pesos.");
            timer = 0;
        }
    }
}
