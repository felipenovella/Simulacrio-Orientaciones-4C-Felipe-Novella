using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{ 


    public string nombreAlumno;
    public int añoAlumno;
    public string orientacionAlumno;




    
    void Start()
    {
        if (nombreAlumno == "")

        {
            Debug.Log("Falta nombre");
            return;

        } if (añoAlumno > 0 && añoAlumno < 3)
        {
            Debug.Log("Aun estás en el ciclo basico");
            return;
        } else if (añoAlumno < 0 || añoAlumno > 5)
        {
            Debug.Log("Año incorrecto");
            return;
        }
        
        if (orientacionAlumno == "T" || orientacionAlumno == "D" || orientacionAlumno == "G" || orientacionAlumno == "M" || orientacionAlumno == "H")
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
            

        } else
        {
            Debug.Log("Orientacion Incorrecta");
        }


    } 
       

    
    void Update()
    {
        
    }
}
