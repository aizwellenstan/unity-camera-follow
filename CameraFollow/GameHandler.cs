using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;

    public Transform playerTransform; // Target

    //---------add Switch Target-------------
    // public Transform character1Transform;
    // public Transform character2Transform;
    // public Transform manualMovementTransform;
    //---------end add Switch Target-----------------

    private void Start()
    {
        // cameraFollow.Setup(new Vector3(0, -100)); // Looking Down
        
        // cameraFollow.Setup(() => new Vector3(0, -100));

        cameraFollow.Setup(() => playerTransform.position);

        cameraFollow.SetGetCameraFollowPositionFunc(() => playerTransform.position);
        //---------add Switch Target-------------
        // cameraFollow.SetGetFollowPositionFunc(() => character1Transform.position);
        //-------end add Switch Target----------
    }
}