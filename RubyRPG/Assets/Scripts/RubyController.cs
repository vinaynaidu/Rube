using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;

        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10; // Controll framerate
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x += speed * Time.deltaTime * horizontal;
        position.y += speed * Time.deltaTime * vertical;
        transform.position = position;
    }
}
