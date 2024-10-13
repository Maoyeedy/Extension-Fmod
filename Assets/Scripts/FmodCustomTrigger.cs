using System;
using FMODUnity;
using UnityEngine;

public class FmodCustomTrigger : MonoBehaviour
{
    public StudioEventEmitter Emitter;
    private void Start()
    {
        if (Emitter == null) Emitter = GetComponent<StudioEventEmitter>();
        Emitter.Play();
        // _emitter.Stop();
    }
}