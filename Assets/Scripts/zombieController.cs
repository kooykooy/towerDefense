using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {

    ZombieData zombieData;
    int currentPath;
    public Sprite[] spriteZombie;
    Sprite currentSprite;

	// Use this for initialization
	void Start () {
        currentSprite = spriteZombie[0];
        GetComponent<SpriteRenderer>().sprite = currentSprite;
        zombieData = ScriptableObject.CreateInstance<ZombieData>();
        zombieData.path = new Vector2[3];
        zombieData.path[0] = new Vector2(-6.11f, -5.4f);
        zombieData.path[1] = new Vector2(-6.11f, 3);
        zombieData.path[2] = new Vector2(9.5f, 3);
        currentPath = 0;
    }
	
	// Update is called once per frame
	void Update () {
       
        if(currentPath != zombieData.path.Length)
        {
            if (Mathf.Round(transform.position.x) != Mathf.Round(zombieData.path[currentPath].x) || Mathf.Round(transform.position.y) != Mathf.Round(zombieData.path[currentPath].y))
            {
                if (zombieData.path[currentPath].x > 0 && (Mathf.Round(transform.position.x) != Mathf.Round(zombieData.path[currentPath].x)))
                {
                    transform.Translate(Vector2.right * Time.deltaTime * zombieData.movementSpeed);
                }
                else if (zombieData.path[currentPath].x < 0 && (Mathf.Round(transform.position.x) != Mathf.Round(zombieData.path[currentPath].x)))
                {
                    transform.Translate(Vector2.left * Time.deltaTime * zombieData.movementSpeed);
                }
                else if (zombieData.path[currentPath].y > 0 && (Mathf.Round(transform.position.y) != Mathf.Round(zombieData.path[currentPath].y)))
                {
                    transform.Translate(Vector2.up * Time.deltaTime * zombieData.movementSpeed);
                }
                else if (zombieData.path[currentPath].y < 0 && (Mathf.Round(transform.position.y) != Mathf.Round(zombieData.path[currentPath].y)))
                {
                    transform.Translate(Vector2.down * Time.deltaTime * zombieData.movementSpeed);
                }
            }
            else
            {
                currentPath++;
            }
        }
	}
}
