using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject objectToTel = null;
    public float playerMaxHealth;
    public float playerDamageAmount;
    public float playerCurrentHealth;
    public TMP_Text healthText;
    public Vector3 destination = new Vector3(-757, 86, 3545);

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerCurrentHealth.ToString();
        if(playerCurrentHealth<=0)
        {

            objectToTel.transform.position = destination;
            Debug.Log("GAME OVER");

        }
    }
    public void ApplyFireDamage()
    {

        playerCurrentHealth = playerCurrentHealth - playerDamageAmount;

        Debug.Log("damage taken");

    }
}

