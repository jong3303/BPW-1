using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    public bool TriggerScene = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.tag == "Carryable")
        {
            Debug.Log("Cutscene is triggered");
        }
    }
}
