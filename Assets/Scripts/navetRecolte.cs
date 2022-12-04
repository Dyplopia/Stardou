using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class navetRecolte : MonoBehaviour
{
    public GameObject stock;
    public bool arroselect = false;

    private bool plan1mouiller = false;
    private bool plan2mouiller = false;

    float timemouiller = 0f;
    float time2mouiller = 0f;

    float timer = 0f;
    float timer2 = 0f;

    bool navetReady = false;
    bool navet2Ready = false;

    public GameObject[] _stageNavet;
    public GameObject[] _stageNavet2 = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        _stageNavet = new GameObject[3];
        _stageNavet[0] = GameObject.Find("navetS1");
        _stageNavet[1] = GameObject.Find("navetS2");
        _stageNavet[2] = GameObject.Find("navetS3");
        _stageNavet[0].SetActive(false);
        _stageNavet[1].SetActive(false);
        _stageNavet[2].SetActive(false);

        _stageNavet2[0] = GameObject.Find("navet2S1");
        _stageNavet2[1] = GameObject.Find("navet2S2");
        _stageNavet2[2] = GameObject.Find("navet2S3");
        _stageNavet2[0].SetActive(false);
        _stageNavet2[1].SetActive(false);
        _stageNavet2[2].SetActive(false);

        stock = GameObject.Find("StockGraines");
    }

    // Update is called once per frame
    void Update()
    {
        tpsArro();
        NavetGrowth();
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

    public void OnClickArroser1()
    {
        //if (stock.GetComponent<stockGraine>().selectNavet == false)
        //{
            if (arroselect == true && plan1mouiller == false)
            {
                Debug.Log("Le plan est arrosé.");
                plan1mouiller = true;
                arroselect = false;
                Debug.Log("Arrosoir déséquipé.");

            //temps de sol mouillé avant de devoir ré-arroser
                tpsArro();

            //temps de croissance du navet
                NavetGrowth();

            }

            else if (arroselect == true && plan1mouiller == true)
            {
                Debug.Log("Plan déjà arrosé.");
            }
    }

    public void OnClickArroser2()
    { 
            if (arroselect == true && plan2mouiller == false)
            {
                Debug.Log("Le plan est arrosé.");
                plan2mouiller = true;
                arroselect = false;
                Debug.Log("Arrosoir déséquipé.");
            //temps de sol mouillé avant de devoir ré-arroser
                tpsArro();
            //temps de croissance du navet
                NavetGrowth();

            }

            else if (arroselect == true && plan2mouiller == true)
            {
                Debug.Log("Plan déjà arrosé.");
            }   
        //}
    }

    public void tpsArro()
    {
        if (plan1mouiller == true)
        {
            timemouiller += 1 * Time.deltaTime;
            if (timemouiller >= 3)
            {
                plan1mouiller = false;
                Debug.Log("Le plan a besoin d'eau.");
                timemouiller = 0;
            }
        }

        if (plan2mouiller == true)
        {
            time2mouiller += 1 * Time.deltaTime;
            if (time2mouiller >= 3)
            {
                plan2mouiller = false;
                Debug.Log("Le plan a besoin d'eau.");
                time2mouiller = 0;
            }
        }
    }

    public void NavetGrowth()
    {
        if (GetComponent<planNavets>().usedplan1 == true)
        {
            //Debug.Log("plan utilisé"); en commentaire sinon spam

            if (plan1mouiller == true)
            {
                timer += 1 * Time.deltaTime;
                if (timer >= 1)
                {
                    _stageNavet[0].SetActive(true);
                    Debug.Log("Le navet a grandit.");
                }

                if (timer >= 3)
                {
                    _stageNavet[0].SetActive(false);
                    _stageNavet[1].SetActive(true);
                    Debug.Log("Le navet pousse encore.");
                }

                if (timer >= 6)
                {
                    _stageNavet[1].SetActive(false);
                    _stageNavet[2].SetActive(true);
                    navetReady = true;
                    Debug.Log("Le navet peut être récolté.");
                }
            }
        }

        if (GetComponent<planNavets>().usedplan2 == true)
        {
            if (plan2mouiller == true)
            {
                timer2 += 1 * Time.deltaTime;
                if (timer2 >= 1)
                {
                    _stageNavet2[0].SetActive(true);
                    Debug.Log("Le navet a grandit.");

                }

                if (timer2 >= 3)
                {
                    _stageNavet2[0].SetActive(false);
                    _stageNavet2[1].SetActive(true);

                    Debug.Log("Le navet pousse encore.");

                }

                if (timer2 >= 6)
                {
                    _stageNavet2[1].SetActive(false);
                    _stageNavet2[2].SetActive(true);
                    navet2Ready = true;

                    Debug.Log("Le navet peut être récolté.");
                }
            }
        }
    }

    public void OnclickRecolte()
    {
        if (navetReady == true && arroselect ==false)
        {
            _stageNavet[2].SetActive(false);
            navetReady = false;
            GetComponent<planNavets>().usedplan1 = false;
            GetComponent<achatPlantes>().argent += 20;
            Debug.Log("Le navet a été récolté. Vous l'avez vendu 20 pesos.");
            timer = 0;
        }

        if (navet2Ready == true && arroselect == false)
        {
            _stageNavet2[2].SetActive(false);
            navet2Ready = false;
            GetComponent<planNavets>().usedplan2 = false;
            GetComponent<achatPlantes>().argent += 20;
            Debug.Log("Le navet a été récolté. Vous l'avez vendu 20 pesos.");
            timer2 = 0;
        }
    }
}
