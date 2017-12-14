using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePlayer : MonoBehaviour 
{

    #region Public Members
    // Les publics en début de code : car un autre dev en a besoin
    public SphereCollider m_Player;


	#endregion

	#region Public void

	#endregion

	#region System

	// La region System ne doit avoir que des appels a des fonctions
	void Start () 
	{
        
    }

    public void playerScale()
    {
        if (GameObject.Find("Score").GetComponent<GestionScore>().Score > 0)
        {
            m_Player.transform.localScale += new Vector3(0.015f, 0.015f, 0.015f);
        }
    }

    void Update()
    {
        
    }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

    // Les privates en fin de code : car un autre dev n'en a pas besoin

    #endregion
}
