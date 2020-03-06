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
        DetectingEnemies();
    }

    void Attacking(){

        attackCharge += Time.deltaTime;
        if(attackCharge >= attackSpeed){
            Debug.Log("Shots Fired");
            attackCharge = 0;
        }
    }

    void DetectingEnemies(){
        // Check for Mobs with attackrange components sphere collider
        Collider[] detectedEnemies = Physics.OverlapSphere(this.transform.position, attackRange);
        for(int i = 0; i < detectedEnemies.Length; i++){
            // Run through list to find closest enemy to core

            // Then assiagn to target
            if(detectedEnemies[i].tag == "EnemyMob"){

                // Implement Distance tracking for closest will implement other such as furthest later
                // Refactor Target Locking toa place that runs once 
                mobTarget = detectedEnemies[i].gameObject;
                Debug.Log("Found Bug...");
                
            }
            
        }
    }

    // Debug
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}



