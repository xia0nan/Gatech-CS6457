using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(CharacterInputController))]
public class MinionScript : MonoBehaviour {

    CharacterInputController cinput;

    float lastTalk;
    float targetTalk;
    float targetTalkBase = 3f;
    float targetTalkMaxRand = 3f;

  
	// Use this for initialization
	void Awake () {

        cinput = GetComponent<CharacterInputController>();
	}

    protected float birthTime;

    protected bool readyToGo = false;

    void setTargetTalk() {
        
        targetTalk = targetTalkBase + Random.value * targetTalkMaxRand;
    }

    void Start() {

        lastTalk = Time.timeSinceLevelLoad;

        setTargetTalk();
    }


	

	void Update () {

        if (Time.timeSinceLevelLoad - lastTalk > targetTalk)
        {
            lastTalk = Time.timeSinceLevelLoad;

            if(cinput != null && cinput.enabled)
                EventManager.TriggerEvent<MinionJabberEvent, Vector3>(transform.position);
            
            setTargetTalk();
        }      

	}








}
