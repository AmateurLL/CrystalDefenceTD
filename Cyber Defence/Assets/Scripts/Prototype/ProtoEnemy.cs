using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoEnemy : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody m_Rigbody;

    public GameObject m_TestTarget;

    [Space]
    [Header("Stats")]
    public float health = 10.0f;
    public float movementSpeed = 2.0f;

    [Space]
    [Header("Misc")]
    public float distToCrystal = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistanceToCrystal();
        MoveToTarget();

    }

    void CheckDistanceToCrystal(){

        distToCrystal = Vector3.Distance(m_TestTarget.transform.position, this.transform.position);
        //Debug.Log("Crystal Distance : " + distToCrystal);
    }

    void MoveToTarget(){

        if(distToCrystal >= 3.0f){
        transform.position = Vector3.MoveTowards(transform.position, m_TestTarget.transform.position, (movementSpeed * Time.deltaTime));
        }
    }

}
