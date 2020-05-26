using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;

    private void Start()
    {
        cameraFollow.Setup(new Vector3(0, -100)); // Looking Down
    }
}