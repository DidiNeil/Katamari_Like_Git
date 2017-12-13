
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimant : MonoBehaviour
{
    #region Public Members

    public BoxCollider cube1;
    public Transform player;

    #endregion

    #region Publuc void

    #endregion

    #region system

    void Start () //pas de logique dans start et update
    {
            
	}
	
	
	void Update () 
    {
		
	}

    private void OnCollisionEnter(Collision cube1)
    {
        

        Debug.Log("Collsion");

        //TODO TOmorrow
        //cube1.transform.parent= (player);
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private float m_myFirstFloat;

    #endregion
}
