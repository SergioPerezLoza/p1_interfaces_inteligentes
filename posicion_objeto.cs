using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicion_objetos : MonoBehaviour
{
    // Creamos un array de GameObjects donde asigno mi esfera, cilindro, cubo y capsula
    public GameObject[] objetos;
    // Start se ejecuta una vez al iniciar la escena
    void Start()
    {
        // Recorremos todos los objetos en el array y mostramos su posición en la consola
        foreach (GameObject obj in objetos)
        {
            if (obj != null) // Verificamos que el objeto no es nulo
            {
                Vector3 posicion = obj.transform.position;
                Debug.Log(obj.name + " está en la posición: " + posicion);
            }
        }
    }
    void Update()
    {
    }
}
