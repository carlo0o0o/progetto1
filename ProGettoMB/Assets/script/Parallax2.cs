using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Parallax2 : MonoBehaviour
{
    //13

    float depth = 5;

    Player player;

    private void Awake() => player = GameObject.Find("Player").GetComponent<Player>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float realVelocity = player.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -5)
            pos.x = 50;

        transform.position = pos;
    }
}

