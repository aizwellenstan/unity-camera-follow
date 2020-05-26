using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;

    public Transform playerTransform; // Target

    private void Start()
    {
        // cameraFollow.Setup(new Vector3(0, -100)); // Looking Down
        
        // cameraFollow.Setup(() => new Vector3(0, -100));

        cameraFollow.Setup(() => playerTransform.position);
    }
}