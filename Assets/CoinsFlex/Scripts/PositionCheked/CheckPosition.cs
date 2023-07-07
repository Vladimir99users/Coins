using UnityEngine;

public abstract class CheckPosition : MonoBehaviour
{
    protected InputActionDatas _inputData;
    public abstract Vector2 GetCurrentPosition();
}
