using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    public bool TriggerScene = false;
    public PlayableDirector timeline;
    public FollowPlayer LanternFollow;

    void Start()
    {
        timeline = timeline.GetComponent<PlayableDirector>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Carryable" && LanternFollow.PickUp == true)
        {
            Debug.Log("Cutscene is triggered");
            timeline.Play();
        }
    }
    void OnEnable()
    {
        timeline.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (timeline == aDirector)
        {
            timeline.enabled = false;
        }
    }
    void OnDisable()
    {
        timeline.stopped -= OnPlayableDirectorStopped;
    }
}
