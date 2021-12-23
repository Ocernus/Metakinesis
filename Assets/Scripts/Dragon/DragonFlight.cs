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
    public ParticleSystem fireParticle;

    // // // //
    
    private float pitch;
    private float yaw;
    private float roll;
    private bool rollR;
    private bool rollL;
    private float tempRoll;

    private Vector2 skate;

    private bool elevateSwitch;
    public float elevatePower;

    public float power;

    // // // // // // // //

    public static DragonFlight instance;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //impactSound.Play();
        bounceDirection = collision.contacts[0].point - transform.position;
        bounceDirection = -bounceDirection.normalized;
        rb.AddForce(bounceDirection * bounceForce);

    }

    //++//

    public void OnRollLeft(InputAction.CallbackContext value)
    {
        //tempRoll = value.ReadValue<float>();
        if (value.started)
        {

        }
    }

    public void OnRollRight(InputAction.CallbackContext value)
    {
        //tempRoll = value.ReadValue<float>();
    }

    public void OnLook(InputAction.CallbackContext value)
    {
        pitch = value.ReadValue<float>();        
    }

    public void OnTurn(InputAction.CallbackContext value)
    {
        yaw = value.ReadValue<float>();
    }

    public void OnShoot(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            fireParticle.Play();
        }
        if (value.canceled)
        {
            fireParticle.Stop();
        }
    }

    public void OnSkate(InputAction.CallbackContext value)
    {
        skate = value.ReadValue<Vector2>();
    }

    public void OnElevate(InputAction.CallbackContext value)
    {
        if (value.started) elevateSwitch = true;
        if (value.canceled) elevateSwitch = false;
    }
    /*
    public void OnElevate(InputAction.CallbackContext value)
    {
        if (value.started) elevateSwitch = true;
        if (value.canceled) elevateSwitch = false;
    }
    */
    // ++ //

    private void StartRoll()
    {
        roll = tempRoll;
    }

    private void StopRoll()
    {
        roll = 0f;
    }

    private void Update()
    {
        if (rollL && !rollR)
        {
            StartRoll();
        }
        if (rollR && !rollL)
        {
            StartRoll();
        }
        if (rollL && rollR)
        {
            StopRoll();
        }
    }

    private void FixedUpdate()
    {
        // Geetting samlpes
        //velocity = rb.velocity.magnitude;
        //currentTorque = rb.angularVelocity.magnitude;

        //addingforces horizon/linear movement
        rb.AddTorque((transform.up * yaw * torque));
        rb.AddTorque((transform.right * pitch * torque));
        rb.AddTorque((transform.forward * roll * torque));

        rb.AddForce((transform.forward * skate.y * force) + (transform.right * skate.x * force));
        if (elevateSwitch) rb.AddForce(transform.up * elevatePower);
    }
}
