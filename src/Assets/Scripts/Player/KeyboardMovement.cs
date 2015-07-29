using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public float MoveSpeed = 3.5f;

    void Update()
    {
        var horizontalMovement = Input.GetAxisRaw("Horizontal");
        var verticalMovement = Input.GetAxisRaw("Vertical");

        var movement = new Vector3(horizontalMovement, 0, verticalMovement) * Time.deltaTime;

        transform.Translate(movement);
    }
}