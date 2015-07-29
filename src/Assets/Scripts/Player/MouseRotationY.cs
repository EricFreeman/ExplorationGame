using Assets.Scripts.Configuration;
using UnityEngine;

public class MouseRotationY : MonoBehaviour
{
    void Update()
    {
        var verticalTurn = Input.GetAxis("Mouse Y") * MouseConfiguration.MouseSensetivity * Time.deltaTime * -1;
        transform.Rotate(verticalTurn, 0, 0);
    }
}