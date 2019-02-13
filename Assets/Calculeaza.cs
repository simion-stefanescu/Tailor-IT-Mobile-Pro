using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculeaza : MonoBehaviour
{
    public InputField inputField;
   public double constanta;
    public double lungime_picior;
    public double latime_sold;
    public double latime_umeri;
    public double latime_maini;
    public double inaltime;
    public double input;

    

    void Start()
    {
        
  
    }

    // Update is called once per frame
    public void Memoreaza()
    {
        input = double.Parse(inputField.text);
        //input = double.Parse(inputField);
        constanta = input / 1.2;
        inaltime = input;
        latime_maini = constanta * 1.2;
        latime_umeri = constanta * 0.3;
        latime_sold = constanta * 0.2;
        lungime_picior = constanta * 0.6;

       
            Debug.Log(inaltime);
        
            
    }
}
