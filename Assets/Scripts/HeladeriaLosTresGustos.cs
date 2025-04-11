using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string gusto;
    public int cantHeladoGramos;

    float promocionFrutilla = 0.9f;
    float precioHelado;
    float precioPorKilo = 1250;
 
    

    void Start()
    {
     
        if (cantHeladoGramos < 250 || cantHeladoGramos > 3000)
        {
            Debug.Log("Cantidad de helado no válida");
            return;
        }
        if (gusto != "CHO" && gusto != "FRU" && gusto != "DDL")
        {
            Debug.Log("Código no válido");
            return;
        }

         precioHelado = cantHeladoGramos * precioPorKilo / 1000 ;

         if (gusto == "FRU")
         {
            precioHelado = cantHeladoGramos * promocionFrutilla;
         }


        Debug.Log("Debe abonar $ " + precioHelado);

    }



    void Update()
    {
        
    }
}
