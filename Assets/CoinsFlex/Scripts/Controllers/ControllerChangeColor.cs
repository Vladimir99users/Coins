using UnityEngine;
using UnityEngine.InputSystem;

public abstract class ControllerChangeColor :  Controller
{
    protected InputAction _changeShapeColorController;

    public ControllerChangeColor()
    {

    }

    public override void Initialize()
    {
        _inputData = new InputActionDatas();

        _changeShapeColorController = _inputData.PlayerInteraction.Tap;
        _changeShapeColorController.Enable();
    }

    public override void UnInitialize()
    {
        _changeShapeColorController.Disable();
    }

    protected abstract void RegistrateTapAction();
}
