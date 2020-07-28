using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region Serialize Fields

    [SerializeField]
    protected int _health = 1;

    [SerializeField]
    protected float _travelTime = 1.0f;

    [SerializeField]
    protected float _speed = 4.0f;

    #endregion

    #region Fields

    protected float _startTime;
    protected float _scale = 0.0f;
    protected Vector3[] _trajectory;
    protected int _trajectoryCounter = 0;
    private Player _player;

    #endregion

    #region Properties

    public bool Swoon
    {
        get 
        {
            return _health < 1;
        }
    }

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        if (_player == null)
        {
            Debug.Log("Projectile._player is null");
        }

        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(GetComponent<CircleCollider2D>().bounds.min, GetComponent<CircleCollider2D>().bounds.max, Color.red, Time.deltaTime, false);
    }

    void OnMouseOver()
    {
        MouseOverDetected();
    }

    #endregion

    #region Protected Methods

    protected virtual void TravelPath()
    {

    }

    protected virtual bool MouseOverDetected()
    {
        Debug.Log("Ball collider");

        //if (_player.MouseClicked())
        //{
        //    Debug.Log("Player clicked on projectile");
        //    return true;
        //}

        return false;
    }

    #endregion
}
