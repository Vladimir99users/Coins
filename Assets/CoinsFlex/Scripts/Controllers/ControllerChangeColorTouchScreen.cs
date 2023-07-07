using UnityEngine;


public class ControllerChangeColorTouchScreen : ControllerChangeColor
{
    private Shape _shape;
    public ControllerChangeColorTouchScreen(Shape shape) : base()
    {
        _shape = shape;
    }

    public override void Initialize()
    {
        base.Initialize();
        RegistrateTapAction();
    }
    protected override void RegistrateTapAction()
    {
        _changeShapeColorController.performed += _shape.SetTapBindingsOnTheMethod;
    }
}
