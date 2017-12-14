using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauche_Droit : MonoBehaviour 
{

    #region Public Members

    public float sensibilite = 1;
   
	#endregion

	#region Public void

	#endregion

	#region System

    void FixedUpdate () 
	{
        float gauche_droite = Input.GetAxisRaw("Horizontal");
        Vector3 move = new Vector3(gauche_droite*sensibilite, 0.0f, 0.0f);

        Quaternion rotation_de_Direction = Quaternion.Euler(0,transform.rotation.y , 0);
        Quaternion rotation_de_sphere = Quaternion.Euler(0,GetComponentInChildren<Transform>().rotation.y , 0) ;

        rotation_de_Direction = rotation_de_sphere;

        if(Input.GetKeyDown("right") || Input.GetKeyDown("left"))
        {
            
            GetComponentInChildren<Rigidbody>().velocity = move;
        }

    }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

    

    // Les privates en fin de code : car un autre dev n'en a pas besoin

    #endregion
}
