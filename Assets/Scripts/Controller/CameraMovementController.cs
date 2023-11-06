using UnityEngine;

/// <summary>
/// �������� �� ���������� �������
/// </summary>
public class CameraMovementController : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public float zoomSpeed;
    public float maxVerticalAngle; // ������������ ���� ������� �����
    public float minVerticalAngle; // ������������ ���� ������� ����

    private float rotationX = 0;

    void Update()
    {
        //��������� ����������� ��������
        Vector3 moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) moveDirection += transform.forward;
        if (Input.GetKey(KeyCode.S)) moveDirection -= transform.forward;
        if (Input.GetKey(KeyCode.A)) moveDirection -= transform.right;
        if (Input.GetKey(KeyCode.D)) moveDirection += transform.right;
        moveDirection.Normalize();

        // ����������� ������
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        // �������� ������
        if (Input.GetMouseButton(1)) // ������ ������ ����
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotationX -= mouseY * rotationSpeed;
            rotationX = Mathf.Clamp(rotationX, minVerticalAngle, maxVerticalAngle);

            transform.rotation = Quaternion.Euler(rotationX, transform.eulerAngles.y + mouseX * rotationSpeed, 0);
        }

        // �����������/��������� ������
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView - scrollInput * zoomSpeed, 10f, 100f);
    }
}
