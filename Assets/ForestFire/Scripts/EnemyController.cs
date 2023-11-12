using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerHealth playerHealthScript;
    public float damageValue;
    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            playerHealthScript.playerCurrentHealth = playerHealthScript.playerCurrentHealth - damageValue;
            //Debug.Log(playerHealthScript.playerCurrentHealth);

        }
        


    }
}
