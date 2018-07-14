using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {

    ZombieData zombieData;

	// Use this for initialization
	void Start () {
        zombieData = ScriptableObject.CreateInstance<ZombieData>();        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * Time.deltaTime *  zombieData.movementSpeed);
	}
}
