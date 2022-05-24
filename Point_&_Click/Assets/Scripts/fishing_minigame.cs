using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_minigame : MonoBehaviour
{
    public GameObject orb;
    public GameObject dullOrb;
    public bool complete;
    public Location local;
    public AudioSource click;

    [Header("Fishing Area")]
    [SerializeField] Transform topBounds;
    [SerializeField] Transform bottomBounds;
    
    [Header("Fish Settings")]
    [SerializeField] Transform fish;
    [SerializeField] float smoothMotion = 3f;
    [SerializeField] float fishTimeRandomizer = 3f;
    float fishPosition;
    float fishSpeed;
    float fishTimer;
    float fishTargetPosition;
    
    [Header("Hook Settings")]
    [SerializeField] Transform hook;
    [SerializeField] float hookSize = 0.18f;
    [SerializeField] float hookSpeed = 0.1f;
    [SerializeField] float hookGravity = 0.05f;
    float hookPosition;
    float hookPullVelocity;

    [Header("Progress Bar Settings")]
    [SerializeField] Transform progressBarContainer;
    [SerializeField] float hookPower;
    [SerializeField] float progressBarDecay;
    float catchProgress;

    bool checkpoint;

    [HideInInspector]
    public bool sound = false;

    private void Start() {
        catchProgress = 0;
        complete = false;
        checkpoint = false;
    }

    private void FixedUpdate() {
        MoveFish();
        MoveHook();
        CheckProgress();
    }

    private void CheckProgress() {
        Vector3 progressBarScale = progressBarContainer.localScale;
        progressBarScale.y = catchProgress;
        progressBarContainer.localScale = progressBarScale;

        float min = hookPosition - hookSize / 2;
        float max = hookPosition + hookSize / 2;
        if (!complete) {
            if (min < fishPosition && fishPosition < max) {
                catchProgress += hookPower * Time.deltaTime;
                if (catchProgress >= 0.5f) {
                    checkpoint = true;
                }
                if (catchProgress >= 1)
                {
                    // Debug.Log("you win!!!! fishy");
                    orb.transform.Translate(-1, 0, 0);
                    dullOrb.transform.Translate(1, 0, 0);
                    complete = true;

                    if (sound == false)
                    {
                        SoundCheck();
                    }
                }
            }
            else {
                if (checkpoint) {
                    if (catchProgress > 0.5f) {
                        catchProgress -= progressBarDecay * Time.deltaTime;
                    }
                }
                else {
                    catchProgress -= progressBarDecay * Time.deltaTime;
                    if (catchProgress <= 0) {
                        //Debug.Log("you lose!!!! fishy");
                    }
                }

            }
            catchProgress = Mathf.Clamp(catchProgress, 0, 1);
        }
    }

    private void MoveHook() {
        if (Input.GetMouseButton(0)) {
            if (local == GameManager.ins.currentNode.GetComponent<Location>())
            {
                hookPullVelocity += hookSpeed * Time.deltaTime;
            }
        }
        hookPullVelocity -= hookGravity * Time.deltaTime;

        hookPosition += hookPullVelocity;

        if (hookPosition - hookSize / 2 <= 0 && hookPullVelocity < 0) {
            hookPullVelocity = 0;
        }

        if (hookPosition + hookSize / 2 >= 1 && hookPullVelocity > 0) {
            hookPullVelocity = 0;
        }
        
        hookPosition = Mathf.Clamp(hookPosition, hookSize / 2, 1 - hookSize / 2);
        hook.position = Vector3.Lerp(bottomBounds.position, topBounds.position, hookPosition);
    }

    private void MoveFish() {
        fishTimer -= Time.deltaTime;
        if (fishTimer <0) {
            fishTimer = Random.value * fishTimeRandomizer;
            fishTargetPosition = Random.value;
        }
        fishPosition = Mathf.SmoothDamp(fishPosition, fishTargetPosition, ref fishSpeed, smoothMotion);
        fish.position = Vector3.Lerp(bottomBounds.position, topBounds.position, fishPosition);
    }

    private void SoundCheck()
    {
        if (click != null)
        {
            click.Play();
        }

        sound = true;
    }
}
