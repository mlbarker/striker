using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curveball : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        _trajectory = new Vector3[]
        {
            new Vector3(2.0f, 2.0f, 0.0f),
            new Vector3(1.5f, 2.0f, 0.0f),
            new Vector3(-2.0f, -2.0f, 0.0f)
        };

        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(GetComponent<CircleCollider2D>().bounds.min, GetComponent<CircleCollider2D>().bounds.max, Color.red, Time.deltaTime, false);
        TravelPath();
    }

    void OnMouseOver()
    {
        MouseOverDetected();
    }

    protected override void TravelPath()
    {
        _scale = (Time.time - _startTime) / _travelTime;
        if (_trajectoryCounter == 0 && _scale > 0.5f)
        {
            ++_trajectoryCounter;
        }
        else if (_trajectoryCounter == 1 && _scale > 1.0f)
        {
            ++_trajectoryCounter;
        }

        transform.localScale += new Vector3(_scale, _scale);
        transform.Translate(_trajectory[_trajectoryCounter] * _speed * Time.deltaTime);
    }

    protected override bool MouseOverDetected()
    {
        return base.MouseOverDetected();
    }
}
