using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    public bool PickUp = false;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (PickUp)
        {
            transform.position = Player.position + (Player.rotation * offset);
        }

    }
    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Cutscene is triggered" + other.gameObject.tag);
    //    if (other.gameObject.tag == "Trigger")
    //    {
    //        Debug.Log("Cutscene is triggered");
    //    }
    //}
}
