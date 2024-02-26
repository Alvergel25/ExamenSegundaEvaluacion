using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    public AudioClip jumpClip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 0.25f;
            AudioManager.instance.PlayAudio(jumpClip, "jumpSound", false, 0.3f);
        }
    }
}
