using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonFlight : MonoBehaviour
{
    

    

    private Rigidbody rb;
    public bool leftEngineOn;
    public bool rightEngineOn;
    private float powerBalanceY;
    private float powerBalanceX;
    private float powerXAccumulative;
    private float powerYAccumulative;
    private Vector3 bounceDirection;
    public float velocity; // Real-time
    public float maxSpeed; // Derived
    public float currentTorque; // Real-time
    public float maxTurn; // Derived

    // // // // // // // // // 

    public float responsiveness;
    public float torque;
    public float force;

    public float doubleTapTime;
    public float quickTurnPower;

    public float blastRotateSpeed;

    public float bounceForce;

    public float powerLimit;

    public float leftPowerCurrent;
    public float rightPowerCurrent;
    public float upPowerCurrent;
    public float downPowerCurrent;


    public GameObject leftBlast;
    public GameObject rightBlast;

    public AudioSource leftAudio;
    public AudioSource rightAudio;
    public AudioSource pickupSound;
    public AudioSource impactSound;

    public ParticleSystem pickupParticle;

    // // // //
    
    private float vertical;
    private float horizontal;

    public float power;

    private float rAxis;
    private float lAxis;
    private float uAxis;
    private float dAxis;

    // // // // // // // //

    public static DragonFlight instance;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(rb.velocity), Time.deltaTime * 40f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //impactSound.Play();
        bounceDirection = collision.contacts[0].point - transform.position;
        bounceDirection = -bounceDirection.normalized;
        rb.AddForce(bounceDirection * bounceForce);

    }

    //++//

    public void OnLook(InputAction.CallbackContext value)
    {
        vertical = value.ReadValue<float>();        
    }

    public void OnTurn(InputAction.CallbackContext value)
    {
        horizontal = value.ReadValue<float>();
    }

    // ++ //

    private void FixedUpdate()
    {
        // Geetting samlpes
        //velocity = rb.velocity.magnitude;
        //currentTorque = rb.angularVelocity.magnitude;

        //addingforces horizon/linear movement
        rb.AddTorque((transform.up * horizontal * torque));
        rb.AddTorque((transform.right * vertical * torque));
        rb.AddForce(transform.forward * Mathf.Min(1, Mathf.Abs(horizontal + vertical)) * force);

    }
}
