using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserControlled : MonoBehaviour
{
    /// <summary>
    /// Laser Speed
    /// </summary>
    [SerializeField]
    [Range(1.0f, 5.0f)]
    public float speed = 1.0f;

    /// <summary>
    /// Refire Speed
    /// </summary>
    [SerializeField]
    [Range(1.0f, 10.0f)]
    public float offset = 1.0f;
    
    private Animator childAnim;


    // Start is called before the first frame update
    void Start()
    {
        childAnim = GetComponentInChildren<Animator>();

        childAnim.SetFloat("play_speed", speed);
        childAnim.SetFloat("pause_speed", offset);

    }
}
