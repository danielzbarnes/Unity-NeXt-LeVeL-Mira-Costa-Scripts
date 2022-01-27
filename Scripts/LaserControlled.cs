using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// a simple script to provide control over laser assets
// this adds two fields to the laser object to control the laser speed and replay speed
// however it's important to note, although these fields can be keyed in an animation clip
// this has no affect the animation playback because the animations are baked at runtime, or something like that...
// while this is functional it lacks the randomness I was after
public class LaserControlled : MonoBehaviour
{
    /// <summary>
    /// Laser Speed
    /// </summary>
    [SerializeField]
    [Range(1.0f, 5.0f)]
    public float speed = 1.0f; // multiplier for the laser_play animation

    /// <summary>
    /// Refire Speed
    /// </summary>
    [SerializeField]
    [Range(1.0f, 10.0f)]
    public float offset = 1.0f; // multiplier for the laser_pause animation
    
    private Animator childAnim;


    // Start is called before the first frame update
    void Start()
    {
        childAnim = GetComponentInChildren<Animator>();

		// the values set here are static regardless of any keys placed on the fields
        childAnim.SetFloat("play_speed", speed);
        childAnim.SetFloat("pause_speed", offset);

    }
}
