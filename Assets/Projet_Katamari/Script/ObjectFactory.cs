using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour 
{


    public GameObject[] _objectToCreated;
    public Transform _where;
    public float _timeBetweenCreatoin=2;



    void Start() {


        InvokeRepeating("CreateOnOfTheObject", 0, _timeBetweenCreatoin);
    }



    void CreateOnOfTheObject() {

        GameObject obj = _objectToCreated[UnityEngine.Random.Range(0, _objectToCreated.Length - 1)];
        GameObject created = Instantiate(obj, _where);
        Aimant.MakeItGlue(created);
    }

	#region Public Members

	// Les publics en début de code : car un autre dev en a besoin

	#endregion

	#region Public void

	#endregion

	#region System

	
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
