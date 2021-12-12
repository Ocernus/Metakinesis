using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragonFlight : MonoBehaviour
{
    

    

    private Rigidbody rb;
    public bool leftEngineOn;
    public bool rightEngineOn;
    private float powerBalance;
    private float powerAccumulative;
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

    public GameObject leftBlast;
    public GameObject rightBlast;

    public AudioSource leftAudio;
    public AudioSource rightAudio;
    public AudioSource pickupSound;
    public AudioSource impactSound;

    public ParticleSystem pickupParticle;

    // // // //
    
    public float vertSpeed;
    public float horzSpeed;
    private float vertical;
    private float horizontal;

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

    void Update()
    {
        maxSpeed = (((powerLimit * 2 * force / rb.drag) - Time.fixedDeltaTime * powerLimit * 2 * force) / rb.mass) / 10;
        maxTurn = (((responsiveness * torque / rb.angularDrag) - Time.fixedDeltaTime * responsiveness * torque) / rb.mass) / 5;

        /*
        if (GameManager.instance.state != GameManager.GameStates.gameOver) CheckInputs();
        if (GameManager.instance.state == GameManager.GameStates.gameOver)
        {
            StopLeftEngine();
            StopRightEngine();
        }
        */

        CheckEngineActivation();

        powerBalance = leftPowerCurrent - rightPowerCurrent;
        powerAccumulative = (leftPowerCurrent / powerLimit) + (rightPowerCurrent / powerLimit);

        //SetEngineAudio();

        /*
        UpdateBlast(leftBlast, leftPowerCurrent / powerLimit, 1);
        UpdateBlast(rightBlast, rightPowerCurrent / powerLimit, -1);
        */


    }

    // ++ //

    public void SwapToFlightMode()
    {
        // parent char to dragon
        // animate char to riding position
        // change map in input system

    }

    void CheckInputs()
    {
        if (Input.GetButtonDown("Left")) StartLeftEngine();
        if (Input.GetButtonDown("Right")) StartRightEngine();
        if (Input.GetButtonUp("Left")) StopLeftEngine();
        if (Input.GetButtonUp("Right")) StopRightEngine();
    }

    void CheckEngineActivation()
    {
        if (leftEngineOn)
        {
            if (leftPowerCurrent < powerLimit) leftPowerCurrent += responsiveness * Time.deltaTime;
            print(leftPowerCurrent);
        }
        else
        {
            if (leftPowerCurrent > 0) leftPowerCurrent -= responsiveness * Time.deltaTime;
            else leftPowerCurrent = 0;
        }

        if (rightEngineOn)
        {
            if (rightPowerCurrent < powerLimit) rightPowerCurrent += responsiveness * Time.deltaTime;
            print(rightPowerCurrent);
        }
        else
        {
            if (rightPowerCurrent > 0) rightPowerCurrent -= responsiveness * Time.deltaTime;
            else rightPowerCurrent = 0;
        }
    }

    public void StartLeftEngine()
    {
        leftEngineOn = true;
    }

    public void StopLeftEngine()
    {
        leftEngineOn = false;
    }

    public void StartRightEngine()
    {
        rightEngineOn = true;
    }

    public void StopRightEngine()
    {
        rightEngineOn = false;
    }

    void SetEngineAudio()
    {
        leftAudio.volume = (leftPowerCurrent / powerLimit) + 0.5f;
        leftAudio.pitch = (leftPowerCurrent / powerLimit) + 0.5f;

        rightAudio.volume = (rightPowerCurrent / powerLimit) + 0.5f;
        rightAudio.pitch = (rightPowerCurrent / powerLimit) + 0.5f;
    }

    public void PlayPickupEffects()
    {
        pickupSound.Play();
        pickupParticle.Play();
    }

    void UpdateBlast(GameObject blast, float power, float mult)
    {
        blast.transform.localScale = new Vector3(blast.transform.localScale.x, power, blast.transform.localScale.z);
    }

    

    //++//

    public void OnRightWing(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            StartRightEngine();
        }
        if (value.canceled)
        {
            StopRightEngine();
        }
    }

    public void OnLeftWing(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            StartLeftEngine();
        }
        if (value.canceled)
        {
            StopLeftEngine();
        }
    }

    public void OnElevate(InputAction.CallbackContext value)
    {
        vertical = value.ReadValue<float>() * vertSpeed;        
    }

    public void OnStrafe(InputAction.CallbackContext value)
    {
        horizontal = value.ReadValue<float>() * horzSpeed;
    }

    // ++ //

    private void FixedUpdate()
    {
        // Geetting samlpes
        velocity = rb.velocity.magnitude;
        currentTorque = rb.angularVelocity.magnitude;

        //addingforces horizon/linear movement
        rb.AddTorque(Vector3.up * powerBalance * torque);
        rb.AddForce((transform.forward * powerAccumulative * force) + (transform.up * vertical) + (transform.right * horizontal));

    }
}
