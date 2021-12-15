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

        powerBalanceY = leftPowerCurrent - rightPowerCurrent;
        powerBalanceX = upPowerCurrent - downPowerCurrent;

        powerYAccumulative = (leftPowerCurrent / powerLimit) + (rightPowerCurrent / powerLimit);
        powerXAccumulative = (upPowerCurrent / powerLimit) + (downPowerCurrent / powerLimit);

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
        /*
        if (Input.GetButtonDown("Left")) StartLeftEngine();
        if (Input.GetButtonDown("Right")) StartRightEngine();
        if (Input.GetButtonUp("Left")) StopLeftEngine();
        if (Input.GetButtonUp("Right")) StopRightEngine();
        */
    }

    void CheckEngineActivation()
    {
        if (leftPowerCurrent < powerLimit) leftPowerCurrent += responsiveness * horizontal * power * Time.deltaTime;
        if (leftPowerCurrent > 0) leftPowerCurrent -= responsiveness * horizontal * power * Time.deltaTime;
        else leftPowerCurrent = 0;

        if (rightPowerCurrent < powerLimit) rightPowerCurrent += responsiveness * horizontal * power * Time.deltaTime;
        if (rightPowerCurrent > 0) rightPowerCurrent -= responsiveness * horizontal * power * Time.deltaTime;
        else rightPowerCurrent = 0;
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
        velocity = rb.velocity.magnitude;
        currentTorque = rb.angularVelocity.magnitude;

        //addingforces horizon/linear movement
        rb.AddTorque((Vector3.up * powerBalanceY * torque) + (Vector3.right * powerBalanceY * torque));
        rb.AddForce((transform.forward * powerYAccumulative * force) + (transform.up * vertical) + (transform.right * horizontal));

    }
}
