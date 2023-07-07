using UnityEngine.InputSystem;
using UnityEngine;

public abstract class Controller 
{
    protected InputActionDatas _inputData;
    public abstract void Initialize();
    public abstract void UnInitialize();
}
