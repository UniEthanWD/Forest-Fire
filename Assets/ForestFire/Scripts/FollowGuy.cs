using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGuy : MonoBehaviour
{
    public GameObject Main_Camera;
    public float followSpeed = 5;
    public bool ontopOfTarget;
    public bool isFollowing;
    // Start is called before the first frame update
    void Start()
    {
        Main_Camera = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(ontopOfTarget==false)
        {
            transform.position = Vector3.MoveTowards(transform.position, Main_Camera.transform.position, followSpeed * Time.deltaTime);

        }
        isFollowing = true;
        Debug.Log("comeing to get you");
    if(ontopOfTarget ==false)
        {
            transform.LookAt(Main_Camera.transform.position);

        }
    
    //if(ontopOfTarget ==true) {
    //        Destroy(gameObject);
    //    }
    transform.LookAt(Main_Camera.transform.position);   
    }
    

}
