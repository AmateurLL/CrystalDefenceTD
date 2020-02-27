using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoCrystalCore : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody m_RigBody;

    [Space]
    [Header("Stats")]
    public bool isAlive = true;
    public float health = 120.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_RigBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckHealth(){
        if(health <= 0){
            isAlive = false;
            // Game Manager will check this to end game
        }
    }

}
