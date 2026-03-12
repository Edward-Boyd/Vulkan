using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{

    public Camera mainCamera;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0f,mainCamera.transform.rotation.eulerAngles.y, 0f);
    }
}
