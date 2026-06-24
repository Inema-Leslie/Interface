using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InterfaceTestScript : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
    Trapezium trap = new Trapezium();
    trap.CalculateUnknownSides();
    trap.CalculateArea();
    trap.CalculatePerimeter();


    Circle circle = new Circle();
    circle.CalculateRadius();
    circle.CalculateArea();
    circle.CalculatePerimeter();


    Nonagon nonagon = new Nonagon();
    nonagon.CalculateArea();
    nonagon.CalculatePerimeter();
    int sides = nonagon.CalculateNumberOfSides();
    Debug.Log("Nonagon number of sides:" + sides);
}
// Update is called once per frame
void Update()
{
}
}
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();

}
public class Trapezium : IShape
{
    float side1 = 5f;
    float side2 = 8f;
    float side3;
    float side4;
    float height = 3f;

public void CalculateUnknownSides()
    {
        side3 = Mathf.Sqrt(height * height + 2f * 2f);
        side4 = Mathf.Sqrt(height * height + 1f * 1f);
        Debug.Log("Trapezium leg1: " + side3 + ", leg2: " + side4);

    }
public void CalculateArea()
{
    // Area = 0.5 * (sum of parallel sides) * height
    float area = 0.5f * (side1 + side2) * height;
    Debug.Log("Trapezium area: + area");
}
public void CalculatePerimeter()
    {
        float perimeter = side1 + side2 + side3 + side4;
        Debug.Log ("Trapezium perimeter:" + perimeter);
    }
}
public class Circle : IShape
{
    float radius = 5f;
public void CalculateArea()
    {
        // area = PI * radius squared
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle area:" + area);
    }
public void CalculateRadius()
    {
        Debug.Log("Circle radius" + radius);
    }
public void CalculatePerimeter()
    {
        //perimeter=radius*2*PI
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log ("Circle perimeter(circumference):" + perimeter );
    }
}
public class Nonagon : IShape
{
int numberOfSides = 9;
float sideLength = 4f;
public void CalculateArea()
    {
        // area of nonagon = (9/4) * s*s * cot(π/n)
        float area = (9f/ 4f) * sideLength * sideLength * (1f / Mathf.Tan(Mathf.PI / 9f));
        Debug.Log("Nonagon area: " + area);
    }
public void CalculatePerimeter()
    {
        float perimeter= numberOfSides * sideLength;
        Debug.Log("Nonagon perimeter: " + perimeter);
    }
public int CalculateNumberOfSides()
{
return numberOfSides;
}
}
