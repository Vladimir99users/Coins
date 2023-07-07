using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Shape : MonoBehaviour
{
    public bool IsCheck {get;set;}
    public abstract void Initialize(Controller controller);
    public abstract void SetTapBindingsOnTheMethod(InputAction.CallbackContext context);
}
