using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionDeathAnimation : MonoBehaviour {


    public GameObject parentGameObject;

    public void ExecuteExplosion() {
        MinionScript ms = parentGameObject.GetComponent<MinionScript>();

        if (ms == null)
            print("XXXXXXXXXXXXX NULLLLLLLLL!!!");

        EventManager.TriggerEvent<MinionDeathEvent, Vector3, MinionScript>(parentGameObject.transform.position + Vector3.up * 0.02f, ms);
    }


    public void ExecuteDestroy()
    {
        Destroy(parentGameObject);

    }
}
