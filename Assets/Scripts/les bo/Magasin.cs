using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magasin : MonoBehaviour
{
    public int argent = 50;
    
    public TMP_Text txtpesos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtpesos.GetComponent<TextMeshProUGUI>().text = argent.ToString() + " €";
    }

}
