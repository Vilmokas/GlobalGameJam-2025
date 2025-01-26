using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SpriteRenderer playerLeftEye;
    [SerializeField] SpriteRenderer playerRightEye;

    public void ChangeEyeColor()
    {
        var color = playerLeftEye.color;
        color.g -= 0.1f;
        color.b -= 0.1f;
        playerLeftEye.color = color;
        playerRightEye.color = color;
    }
}
