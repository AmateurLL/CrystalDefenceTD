using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoTower : MonoBehaviour
{

    [Header("Components")]
    public BoxCollider m_BodyColli;
    public SphereCollider m_AttackRangeColli;

    [Space]
    [Header("Stats")]
    public float health = 15.0f;
    public float attackRange = 12.0f;
    public float attackSpeed = 8.0f;
    public float attackCharge = 0.0f;

    [Space]
    [Header("Misc")]
    public GameObject mobTarget;
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        m_AttackRangeColli = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attacking(){

        attackCharge += Time.deltaTime;
        if(attackCharge >= attackSpeed){
            Debug.Log("Shots Fired");
            attackCharge = 0;
        }
    }

    void OnTriggerEnter(Collider targetsInRange){

        // Ignore Retargetting till initial 
        // target is killed or left out of range
        //if (isAttacking == false){
  
        //}

    }

    void OntriggerExit(Collider targetsInRange){

    }

    void EnemyInRange(){
        // Check for Mobs with attackrange components sphere collider
        //Colliders[] inColliders = m_AttackRangeColli();

    }

}
