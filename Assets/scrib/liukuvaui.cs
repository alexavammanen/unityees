using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liukuvaui : MonoBehaviour
{

    public Slider miksi;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMaxHealth(float healtj)
    {
        miksi.maxValue = healtj;
        miksi.value = healtj;


    }
    public void asetah(float healtj)
    {
        miksi.value = healtj;
    }




    


}
