using UnityEngine;
public class RandomRotateShape : IRotate
{
    private Shape _currentShape;
    public RandomRotateShape(Shape shape)
    {
        _currentShape = shape;
    }
    public Quaternion Rotate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(1, Vector3.right);

        return rotationX * rotationY;
    }
    private Vector3 GetRandomRotation(Vector3 currentRotation)
    {
        float x = Random.Range(0f,360f);
        float y = Random.Range(0f,360f);
        float z = Random.Range(0f,360f);

        return new Vector3(x,y,z);
    }

}
