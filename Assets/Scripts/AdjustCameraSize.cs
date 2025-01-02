using UnityEngine;
using Unity.Cinemachine;

[RequireComponent(typeof(CinemachineCamera))]
public class PortraitAdaptiveCamera : MonoBehaviour
{
    public int referenceVerticalTiles = 10; // Vertical tiles for 9:16 aspect ratio
    public float referenceAspectRatio = 9f / 16f; // Default portrait aspect ratio (9:16)
    public int pixelsPerUnit = 16; // PPU for your sprites

    private CinemachineCamera _cinemachineCamera;

    void Start()
    {
        _cinemachineCamera = GetComponent<CinemachineCamera>();
        AdjustCameraSize();
    }

    void AdjustCameraSize()
    {
        if (_cinemachineCamera != null)
        {
            // Calculate the current aspect ratio
            float currentAspectRatio = (float)Screen.width / Screen.height;

            // If the screen is taller than the reference aspect ratio
            if (currentAspectRatio < referenceAspectRatio)
            {
                // Increase orthographic size proportionally
                float scaleFactor = referenceAspectRatio / currentAspectRatio;
                _cinemachineCamera.Lens.OrthographicSize = (referenceVerticalTiles / 2f) * scaleFactor;
            }
            else
            {
                // Use the default orthographic size for 9:16
                _cinemachineCamera.Lens.OrthographicSize = referenceVerticalTiles / 2f;
            }

            Debug.Log(
                $"Aspect Ratio: {currentAspectRatio}, Orthographic Size: {_cinemachineCamera.Lens.OrthographicSize}, Dimensions: {Screen.width}x{Screen.height}");
        }
    }
}