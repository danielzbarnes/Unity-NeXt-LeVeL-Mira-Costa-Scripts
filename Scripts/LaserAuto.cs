using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;



// a simple script to automatically randomize laser asset animation
// the laser animation consists of two animation loops
// the laser_play animation and the laser_pause animation
public class LaserAuto : MonoBehaviour
{

	// these are multipliers applied to the animation clip playback speeds
    private float speed; 		// the speed the laser moves
    private float offset;		// the delay until the effect starts again
    private Animator anim;		// the Animator control component


    // Start is called before the first frame update
    void Start()
    {        
        anim = this.gameObject.GetComponent<Animator>();

		// initialize the speed and offset multipliers
        UpdateLasers();

		// apply the offset multiplier values to the play_speed & pause_speed animation variables
        anim.SetFloat("play_speed", speed); 
        anim.SetFloat("pause_speed", offset);
    }


	// this randomly sets the movement speed and delay of the laser animations
	// it's triggered by an Animation Event when the laser_play animation clip completes
    public void UpdateLasers()
    {
        speed = Rand(1.0f, 3.0f);
        offset = Rand(1.0f, 5.0f);
    }


    private float Rand(float min, float max)
    {
        
        return Random.Range(min, max);
    }
}


