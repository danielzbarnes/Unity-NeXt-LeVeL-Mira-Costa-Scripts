using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseTranslation : MonoBehaviour
{
    private float speed;
    private float offset;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();

        UpdatePulse();
    }

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


