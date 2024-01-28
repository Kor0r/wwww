using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nps : MonoBehaviour
{
    // Start is called before the first frame update
    public int healh = 5;
    public int level = 1;
    public float speed = 0.7f;
    void Start()
    {
        healh += level;
        print("здоровье игрока"+ healh);
        // пишет злоровье игрока в начае игры
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3();
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
