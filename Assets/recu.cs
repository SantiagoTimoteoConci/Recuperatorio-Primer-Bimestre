using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recu : MonoBehaviour
{
    public string Sabor1;
    public string Sabor2;
    public string Sabor3;
    public int Cant1;
    public int Cant2;
    public int Cant3;
    float precio1;
    float precio2;
    float precio3;
    float descuento;
    float total;
    // Start is called before the first frame update
    void Start()
    {
        precio1 = Cant1 / 2;
        precio2 = Cant2 / 2;
        precio3 = Cant3 / 2;
        if (Cant1 < 250 || Cant2 < 250 || Cant3 < 250 || Cant1 > 3000 || Cant2 > 3000 || Cant3 > 3000)
        {
            Debug.Log("Error");
        }
        else
        {
            if (Sabor1 == "FRU")
            {
                descuento = precio1 * 0.9f;

            }
            if (Sabor2 == "FRU")
            {
                descuento = precio2 * 0.9f;

            }
            if (Sabor3 == "FRU")
            {
                descuento = precio3 * 0.9f;

            }

            if (Sabor3 == "FRU")
            {
                total = precio1 + precio2 + descuento;
                Debug.Log("El monto total es " + total);

            }
            if (Sabor2 == "FRU")
            {
                total = precio1 + precio3 + descuento;
                Debug.Log("El monto total es " + total);

            }
            if (Sabor1 == "FRU")
            {
                total = precio3 + precio2 + descuento;
                Debug.Log("El monto total es " + total);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
