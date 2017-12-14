
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimant : MonoBehaviour
{
    #region Public Members

    public Transform cube1;

    

    #endregion

    #region Publuc void

    #endregion

    #region system

    private void Awake()
    {
        m_transform = transform.GetComponent<Transform>();
    }

    void Start () //pas de logique dans start et update
    {
            
	}
	
	
	void Update () 
    {
		
	}
    public void SetParams(Transform root, int score) {

        this.cube1 = root;
    }

    private void OnCollisionEnter (Collision collision)
    {

        if (collision.transform.CompareTag("Player"))
        {

            cube1.transform.parent = collision.transform;
            RemoveColliders(cube1.gameObject);

            //cube1.transform.GetComponent<BoxCollider>().isTrigger = true;

        }

        //TODO TOmorrow
        //cube1.transform.parent= (player);
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Transform m_transform;
    private Rigidbody m_rigidbody;

    #endregion

    public static void MakeItGlue(GameObject target, int score = 1) {

        Aimant createdscript= target.AddComponent<Aimant>();
       
        createdscript.SetParams(target.transform, score);
    }


    public static void RemoveColliders(GameObject target)
    {
            Destroy(target.transform.GetComponent<Rigidbody>());
            //Supprimer le rigidbody
            target.transform.GetComponent<BoxCollider>().isTrigger = true;
            //Destroy(target.transform.GetComponent<BoxCollider>());
            //Supprimer les colliders


        //target.GetComponents<Collider>();
        //target.GetComponentsInChildren<Collider>();
        //Destroy(collider);
    }
}
