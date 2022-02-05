using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a simple script similiar to the laser scripts
// animates a pulse of light that slides along a light pillar
// uses the same principal as the animated lasers, toggling between play/pause animation clips
public class PulseTranslation : MonoBehaviour
{
	// multipliers applied to animation clip playback speed
    private float speed;	// the speed the pulse will climb the light pillar
    private float offset;	// the delay until the effect restarts
    private Animator anim;	// the Animator control component

    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();

        UpdatePulse();
    }

	// this sets the movement speed and delay of the pulse effect
	// it's triggered by an Animation Event when the pulse_play animation clip completes
    public void UpdatePulse()
    {
        speed = Rand(0.5f, 1.5f);
        offset = Rand(0.5f, 5.0f);
        anim.SetFloat("pulse_speed", speed);
        anim.SetFloat("pulse_offset", offset);
    }


    private float Rand(float min, float max)
    {
        return Random.Range(min, max);
    }
}


