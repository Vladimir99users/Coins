using UnityEngine;
using UnityEngine.InputSystem;

public class Coins : Shape
{
    [SerializeField] private Renderer _renderer;
    private ControllerChangeColor _controllerTap;
    private IRotate _randomRotate;

    public override void Initialize(Controller controller)
    {
        _controllerTap = (ControllerChangeColor)controller;
        _randomRotate = new RandomRotateShape(this);
    }
    public override void SetTapBindingsOnTheMethod(InputAction.CallbackContext context)
    {
        GlobalEventManager.SendMessageOntheTap();

        if(IsCheck)
        {
            SetNewColorInRender();
        }
    }

    protected virtual void SetNewColorInRender()
    {
        _renderer.material.color = GetRandomColor();
    }

    protected virtual Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1);
    }

    private void FixedUpdate()
    {
        this.gameObject.transform.rotation *= _randomRotate.Rotate();
    }
}
