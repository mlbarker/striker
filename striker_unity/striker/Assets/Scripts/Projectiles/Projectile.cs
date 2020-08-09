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

    // series of vectors for the projectile
    // to follow while traveling toward the
    // player
    [SerializeField]
    protected TrajectoryPoint[] _trajectory;
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
        TravelPath();
    }

    void OnMouseOver()
    {
        MouseOverDetected();
    }

    #endregion

    #region Protected Methods

    protected virtual void TravelPath()
    {
        if (_trajectoryCounter != _trajectory.Length)
        {
            _scale = (Time.time - _startTime) / _travelTime;
            _scale *= _speed;

            transform.localScale += new Vector3(_scale, _scale);
            transform.Translate(_trajectory[_trajectoryCounter].Vector * _speed * Time.deltaTime);

            // update to the next point when you reach the scale limit
            if (_scale > _trajectory[_trajectoryCounter].ScaleLimit)
            {
                //Debug.Log("SCALE b/f NEXT TRAJ: " + _scale);
                ++_trajectoryCounter;
            }
        }
        else
        {
            Debug.Log("Destroy projectile");
            DestroyProjectile();
        }
    }

    protected virtual bool MouseOverDetected()
    {
        if (_player.MouseClicked())
        {
            Debug.Log("Player clicked on projectile");
            return true;
        }

        return false;
    }

    protected void DestroyProjectile()
    {
        Destroy(this.gameObject);
    }

    #endregion

    #region Nested Classes
    
    [System.Serializable]
    protected internal class TrajectoryPoint
    {
        #region Fields

        [SerializeField]
        private Vector3 _vector;

        // the max amount of scale that the projectile 
        // reaches before moving to the next trajectory point
        [SerializeField]
        private float _scaleLimit;

        #endregion

        #region Properties

        public Vector3 Vector
        {
            get => _vector;
            private set => _vector = value;
        }

        public float ScaleLimit
        {
            get => _scaleLimit;
            private set => _scaleLimit = value;
        }

        #endregion
    }

    #endregion
}
