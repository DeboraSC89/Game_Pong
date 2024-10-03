using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;

    public SpriteRenderer spriteRenderer;

    public string movementeAxisName = "Vertical2";

    void Update()
    {
        float moveInput = Input.GetAxis(movementeAxisName);
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);
        transform.position = newPosition;
    }
}
