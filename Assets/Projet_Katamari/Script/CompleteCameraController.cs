
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCameraController : MonoBehaviour
{
    #region Public Members

    public GameObject player;       //Public variable to store a reference to the player game object

    #endregion

    #region Publuc void

    #endregion

    #region system

    private void Awake()
    {
        m_transform = GetComponent<Transform>();
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
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        m_transform.position = player.transform.position + offset;
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    private Transform m_transform;


    #endregion
}
