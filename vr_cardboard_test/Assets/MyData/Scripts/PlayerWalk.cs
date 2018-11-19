using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

    public int playerSpeed;
    int TapCount;
    //public float MaxDubbleTapTime;
    float NewTime;
    bool tapping;
    float LastTap;
    float tapTime;
    float _doubleTapTimeD;
    private float holdTime = 0.8f; //or whatever
    private float acumTime = 0;
    public float speed = 0.1F;
    bool hold = false;

    // Use this for initialization
    void Start () {
        TapCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetButton("Fire1")) {
            TapCount += 1;
            if (TapCount == 2) {
                TapCount = 0;
                transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            }
            
        }
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {
                TapCount += 1;
            }

            if (TapCount == 1)
            {

                NewTime = Time.time + MaxDubbleTapTime;
            }
            else if (TapCount == 2 && Time.time <= NewTime)
            {

                //Whatever you want after a dubble tap    
                transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;


                TapCount = 0;
            }

        }
        if (Time.time > NewTime)
        {
            TapCount = 0;
        }*/

        if (Input.GetButtonDown("Fire1")) {
            if (!tapping) {
                tapping = true;
            }
        }

        bool doubleTapD = false;

        #region doubleTapD

        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time < _doubleTapTimeD + .3f)
            {
                doubleTapD = true;
            }
            _doubleTapTimeD = Time.time;
        }

        #endregion

        if (doubleTapD||hold)
        {
            //if (Input.GetButton("Fire1")) {
                hold = true;
                transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            //}
            if (Input.GetButtonUp("Fire1")) {
                hold = false;
            }
            Debug.Log("DoubleTapD");
            
            
        }


    }

}
