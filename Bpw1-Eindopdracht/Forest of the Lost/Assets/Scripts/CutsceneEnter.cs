using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    //public bool TriggerScene = false;
    void OnTriggerEnter (Collider other)
    {
            Debug.Log("Cutscene is triggered");
    }
}
