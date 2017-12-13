
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulade : MonoBehaviour
{
    #region Public Members

    public float _speed;
    public ForceMode _forceType = ForceMode.VelocityChange;

    #endregion

    #region Publuc void

    #endregion

    #region system

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_transform = GetComponent<Transform>();

    }

    void Start () //pas de logique dans start et update
    {
		
	}
	
	
	void Update () 
    {
		
	}

    private void FixedUpdate()
    {
        float _moveHorizontal = Input.GetAxis("Horizontal");
        float _moveVertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_moveHorizontal, 0.0f, _moveVertical);

        Transform maCamera = Camera.main.transform;


        //  Quaternion.Lerp()
        
        Vector3 angle90 = new Vector3(0,0,0);
        Vector3 newDireciton = Quaternion.Euler(angle90) * maCamera.forward;



        m_rigidbody.AddForce(newDireciton * Time.deltaTime*_speed, _forceType);
        m_rigidbody.AddForce(_movement);
        //m_rigidbody.AddRelativeForce(_movement*_speed);
    }


    void OnTriggerEnter(Collider other)//à faire avec des layerMasks??
    {
        if (other.gameObject.CompareTag("Pick Up"))//à changer
        {
            other.gameObject.SetActive(false);
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Rigidbody m_rigidbody;
    private Transform m_transform;

    #endregion
}
