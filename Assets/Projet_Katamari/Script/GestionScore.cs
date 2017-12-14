using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionScore : MonoBehaviour 
{

    #region Public Members

    // Les publics en début de code : car un autre dev en a besoin
    public int Score = 0;
    public Text TextScore;

    



	#endregion

	#region Public void

	#endregion

	#region System

	// La region System ne doit avoir que des appels a des fonctions
	void Start () 
	{
        
    }


    void Update () 
	{
        TextScore.text = Score.ToString();
    }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

    // Les privates en fin de code : car un autre dev n'en a pas besoin

    #endregion
}
