using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class CinemachinePOVExtension : CinemachineExtension
{
    [SerializeField] private float horizontalSensitivity, verticalSensitivity;

    private Vector2 look;
    private Vector3 startingRotation;

    public void OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                if (startingRotation == null) startingRotation = transform.localRotation.eulerAngles;
                startingRotation.x += look.x * verticalSensitivity * Time.deltaTime;
                startingRotation.y += -look.y * horizontalSensitivity * Time.deltaTime;
                startingRotation.y = Mathf.Clamp(startingRotation.y, -90,90);
                state.RawOrientation = Quaternion.Euler(startingRotation.y, startingRotation.x,0f);
            }
        }
    }
}
