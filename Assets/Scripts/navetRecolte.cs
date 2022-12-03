using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navetRecolte : MonoBehaviour
{
    public bool arroselect = false;
    private bool plan;
    float timeBtwStages = 2f;
    float timer;
    public int[] _stageNavet = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        plan = GetComponent<planNavets>().usedplan1;
        plan = GetComponent<planNavets>().usedplan2;
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

    public void NavetGrowth()
    {
        if (plan == true)
        {
 
        }
    }
}
