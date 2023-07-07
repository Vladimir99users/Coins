using UnityEngine;
using UnityEngine.InputSystem;


public class CheckPositionWithMouse : CheckPosition
{
   
    private InputAction _mousePosition;
    private Vector2 _currentPositionOnCoursor;
    private void OnEnable() 
    {
        _inputData = new InputActionDatas();
        _mousePosition = _inputData.PlayerInteraction.PositionMouse;
        _mousePosition.Enable();

        
    }
    private void OnDisable()
    {
        _mousePosition.Disable();
    }

    private void Update()
    {
        _currentPositionOnCoursor = _mousePosition.ReadValue<Vector2>(); 
    }

    public override Vector2 GetCurrentPosition()
    {
        return _currentPositionOnCoursor;
    }

}