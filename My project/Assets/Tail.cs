using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Tail : MonoBehaviour
{
    public float pointSpacing = .1f;
    List<Vector2> points;
    LineRenderer line;
    public Transform snake;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

        points = new List<Vector2>();

        SetPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(points.Last(), snake.position) > pointSpacing) 
            SetPoint();
    }

    void SetPoint()
    {
        points.Add(snake.position);
        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, snake.position);
    }
}
