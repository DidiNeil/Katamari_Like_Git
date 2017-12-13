
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCameraController : MonoBehaviour
{
    #region Public Members

    public GameObject player;       //Public variable to store a reference to the player game object


 //   public  Vector3 _initialRotation = new Vector3(45,45,45);

   



    public float m_speedRotationCamera = 2.0f;

    #endregion

   

    #region Publuc void

    #endregion

    #region system

    private void Awake()
    {



        m_transform = GetComponent<Transform>();
       // m_transform.rotation = Quaternion.Euler(_initialRotation);
    }

    void Start () 
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = m_transform.position - player.transform.position;

    }
	
	
	void Update () 
    {	
	}

    // LateUpdate is called after Update each frame
 //*
   void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        
        m_transform.position = player.transform.position + offset;

        m_gaucheDroite +=   m_speedRotationCamera * Input.GetAxis("Mouse X");

        m_transform.rotation = Quaternion.Euler(new Vector3(0.0f, m_gaucheDroite, 0.0f));
        player.transform.Rotate(m_transform.eulerAngles);

        //Difference entre properties et method, dans des propriétés y a des get;set
        //On ne sait pas ce qu'il y a dedans mais je fais confiance et j'ai le resultat
        //classe static?
        //dans des methode je demandes autant de paramètres et je les utilise quand je sais ce
        //que je fais ex: rotation != Rotate()
        //.rotation peut être utilisé comme une variable




    }//*/

    #endregion

        #region Tools Debug and Utility

        #endregion

        #region Private and Protected Members

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    private Transform m_transform;

    //les noms des variables que j'ai repris d'un autre script
    private float m_gaucheDroite = 0.0f;
  

    #endregion
}
