using UnityEngine;

public class CofigurationDataInGame : MonoBehaviour
{
   [SerializeField] private Shape _shape;
   [SerializeField] private CheckPosition _checkMousePosition;
   private ControllerChangeColor _controllerChangeColor;


    private void Start() 
    {
        SettingsControllerData();
        SetControllerData();
    }
    private void SettingsControllerData()
    {
        if(_shape is null)
        {
            throw new System.Exception("Not set Shape!!!");
        }
 
        SetNewControllerChangeColor(new ControllerChangeColorTouchScreen(_shape));
    }
    private void SetNewControllerChangeColor(Controller controller)
    {
        _controllerChangeColor = controller as ControllerChangeColor; 
        _controllerChangeColor.Initialize();
    }
    private void SetControllerData()
    {
        _shape.Initialize(_controllerChangeColor);
    }

    private void Update() 
    {
        _shape.IsCheck = IsCheckCollider(_checkMousePosition.GetCurrentPosition());
    }

    
    private bool IsCheckCollider(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.TryGetComponent<Shape>( out Shape shape))
            {
                return true;
            }
        }

        return false;
    }
}
