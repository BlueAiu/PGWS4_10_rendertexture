using UnityEngine;

public class Rotate_Script : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 20f;

    void Update()
    {
       transform.Rotate(0, rotateSpeed * Time.deltaTime, 0); 
    }
}
