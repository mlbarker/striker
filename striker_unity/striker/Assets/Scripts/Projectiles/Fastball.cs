using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fastball : Projectile
{
    #region Fields



    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
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

    #endregion

    #region Protected Methods

    protected override void TravelPath()
    {
        _scale = (Time.time - _startTime) / _travelTime;

        transform.localScale += new Vector3(_scale, _scale);
        //transform.Translate(_trajectory[_trajectoryCounter] * _speed * Time.deltaTime);
        //base.TravelPath();
    }

    protected override bool MouseOverDetected()
    {
        return base.MouseOverDetected();
    }

    #endregion
}
