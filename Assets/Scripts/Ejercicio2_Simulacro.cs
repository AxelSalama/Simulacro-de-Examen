using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.


public class Ejercicio2_Simulacro : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    public int monto;
    // Start is called before the first frame update
    void Start()
    {
        int total = precio1 + precio2 + precio3;
        int sobra = monto - precio1 - precio2 - precio3;
        int falta = total - monto;

        if (precio1 + precio2 + precio3 > monto)
        {
            Debug.Log("La suma del precio de los tres valores es mayor al monto disponible y falta " + falta + " pesos.");
        }
        else if (precio1 + precio2 + precio3 < monto)
        {
            Debug.Log("La suma del precio de los tres valores es " + total + " pesos y sobra " + sobra + " pesos.");   
        }
    }
}
