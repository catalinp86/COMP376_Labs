﻿using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
    Animator mAnimator;
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    [SerializeField]
    GameObject mBulletPrefab;
    MegaMan mMegaManRef;

    AudioSource mBusterSound;

    void Start ()
    {
        mAnimator = transform.parent.GetComponent<Animator>();

        // TODO: Get a reference to the following items and store them:
        //          - MegaMan component in the "Mega Man" game object (store in "mMegaManRef")
        //          - AudioSource component in "BusterGun" game object (store in "mBusterSound")
        /*
        mMegaManRef = 
        mBusterSound = 
        */
    }

    void Update ()
    {
        if(Input.GetButtonDown ("Fire"))
        {
            // TODO: Shoot a bullet!
            //       Instantiate it and get a reference of its Bullet Component.
            //       You're going to need it ;)

            // TODO: Set the direction of the bullet
            //       Use the SetDirection() function from the Bullet class

            // TODO: Play the mBusterSound!

            // Set animation params
            mShooting = true;
            mTime = 0.0f;
        }

        if(mShooting)
        {
            mTime += Time.deltaTime;
            if(mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        mAnimator.SetBool ("isShooting", mShooting);
    }
}