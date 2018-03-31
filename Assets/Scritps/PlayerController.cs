using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    public float gravity = -9.8f;
    public float jumpheight = 3.0f;
    public static int health = 10;
    public static bool haveKey = false;

    private CharacterController _charCont;
    
    void Start ()
    {
        _charCont = GetComponent<CharacterController> ();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude (movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charCont.Move(movement);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 jump = new Vector3(0, jumpheight, 0);
            jump = Vector3.ClampMagnitude(jump, jumpheight);
            _charCont.Move(jump);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (haveKey)
            other.gameObject.SetActive(false);
    }
}
