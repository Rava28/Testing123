using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Rotation speed (you can change this in the Inspector)
    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
