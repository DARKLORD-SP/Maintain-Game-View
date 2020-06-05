using UnityEngine;

[ExecuteInEditMode]
/// <summary>
/// Maintains the Game area on different sizes of display.
/// </summary>
public class GameViewMaintainer : MonoBehaviour
{

    public Vector2 targetRes;
    private Camera _camera;

    private float defaultFOV;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {

#if UNITY_EDITOR
        //Inside Editor Game Window The Resolution is retrived by Screen.width and Screen.height
        _camera.aspect = (targetRes.x / targetRes.y) / Screen.width * Screen.width;
#elif UNITY_ANDROID
        //while in any android devices the screens current orientated resolution is taken by Screen.currentResolution
        _camera.aspect = (targetRes.x / targetRes.y) / Screen.currentResolution.width * Screen.currentResolution.width;
#endif

        defaultFOV = _camera.focalLength * _camera.aspect;
        _camera.focalLength = defaultFOV;
    }
}
