using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer : MonoBehaviour {

    public float time;

    public bool timerEnabled;

    public float startTime;

    public bool countdownTimer;



    void Start() {
        if (countdownTimer) {
            startTime = time;
        } else {
            startTime = 0;
        }
        onStart();
    }
    public void FixedUpdate() {

        if (timerEnabled) {
            if (countdownTimer) {

                startTime -= Time.fixedDeltaTime;
            } else {
                startTime += Time.fixedDeltaTime;
            }
            onUpdate();
            if (startTime >= time || startTime <= 0) {
                onTick();
            }
        }

    }


    public void RestartTimer() {
        if (countdownTimer) {
            this.startTime = time;
        } else {
            this.startTime = 0;
        }
        onRestart();
    }

    public virtual void onUpdate() {

    }

    public virtual void onRestart() {

    }

    public virtual void onTick() {

    }

    public virtual void onStart() {

    }


}
