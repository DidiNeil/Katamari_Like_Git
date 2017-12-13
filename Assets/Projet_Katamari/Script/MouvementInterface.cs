using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementInterface : MonoBehaviour 
{

    #region Public Members
    // Les publics en début de code : car un autre dev en a besoin
    public GameObject m_mandala1;
    public GameObject m_mandala2;

    public float turnSpeed = 50f;



    #endregion

    #region Public void

    #endregion

    #region System

    // La region System ne doit avoir que des appels a des fonctions
    void Start () 
	{
        
    }

    private void FixedUpdate()
    {
        m_mandala1.transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
        m_mandala2.transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }

    void Update () 
	{
        
    }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members
    // Les privates en fin de code : car un autre dev n'en a pas besoin


    #endregion
}
