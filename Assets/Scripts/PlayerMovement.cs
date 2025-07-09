using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 worldSize = new Vector2(175, 110);

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

        newPosition.x = Mathf.Clamp(newPosition.x, -worldSize.x / 2, worldSize.x / 2);
        newPosition.y = Mathf.Clamp(newPosition.y, -worldSize.y / 2, worldSize.y / 2);

        transform.position = newPosition;
    }

}