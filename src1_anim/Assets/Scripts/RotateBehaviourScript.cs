using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        // 360‚Åˆêü(360.0f)@‚P•b‚Å‚P‘‚¦‚é(Time.deltaTime)@ˆêü‚Ì•b”(10.0f)
        float rotate = 360.0f * Time.deltaTime / 10.0f;

        this.transform.Rotate(0, rotate, 0);
    }
}
