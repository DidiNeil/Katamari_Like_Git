using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour 
{


    public GameObject[] _objectToCreated;
    public Transform _where;


    public float _timeBetweenCreatoin=2;

    public Vector3 centerSpawnZone;
    public Vector3 sizeSpawnZone;

    void Start() {
        InvokeRepeating("CreateOnOfTheObject", 0, _timeBetweenCreatoin);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0.5f, 0.3f);
        Gizmos.DrawCube(centerSpawnZone, sizeSpawnZone);
    }

//Updated upstream
    void CreateOnOfTheObject()
    {
        Vector3 spawnZone = centerSpawnZone + new Vector3(Random.Range(-sizeSpawnZone.x * 0.5f, sizeSpawnZone.x * 0.5f), 10, Random.Range(-sizeSpawnZone.z * 0.5f, sizeSpawnZone.z * 0.5f));
        GameObject obj = _objectToCreated[UnityEngine.Random.Range(0, _objectToCreated.Length - 1)];
        GameObject created = Instantiate(obj, spawnZone,Quaternion.identity);
        Aimant.MakeItGlue(created);
        ///
    }

    #region Public Members

    // Les publics en début de code : car un autre dev en a besoin

    #endregion

    #region Public void

    #endregion

    #region System



    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

    // Les privates en fin de code : car un autre dev n'en a pas besoin

    #endregion
}
