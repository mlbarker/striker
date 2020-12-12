using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region Statics

    private static uint IdCounter = 0;

    #endregion

    #region Serialize Fields

    [SerializeField]
    protected int _health = 1;

    [SerializeField]
    protected float _travelTime = 1.0f;

    [SerializeField]
    protected float _speed = 4.0f;

    // series of vectors for the projectile
    // to follow while traveling toward the
    // player
    [SerializeField]
    protected TrajectoryPoint[] _trajectory;

    #endregion

    #region Fields

    protected float _startTime;
    protected float _scale = 0.0f;
    protected int _trajectoryCounter = 0;
    protected bool _hitEligible = false;
    protected bool _hit = false;
    protected uint _id = 0;
    private Player _player;
    private GameManager _gameManager;


    #endregion

    #region Properties

    public bool Swoon
    {
        get => _health < 1;
    }

    public bool HitEligible
    {
        get => _hitEligible;
        private set => _hitEligible = value;
    }

    public bool Hit
    {
        get => _hit;
        private set => _hit = value;
    }

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        if (_player == null)
        {
            Debug.LogError("Projectile.Start()._player is null");
        }

        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if(_gameManager == null)
        {
            Debug.LogError("Projectile.Start()._gameManager is null");
        }

        _id = ++IdCounter;

        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug
        Debug.DrawLine(GetComponent<CircleCollider2D>().bounds.min, GetComponent<CircleCollider2D>().bounds.max, Color.red, Time.deltaTime, false);

        TravelPath();
        UpdateHit();
        UpdateSwoon();
    }

    void OnMouseEnter()
    {
        CastRay();
    }

    void OnMouseExit()
    {
        CastRay();
    }

    void OnMouseOver()
    {
        //MouseOverDetected();
    }

    #endregion

    #region Public Methods

    public static void ResetIdCounter()
    {
        IdCounter = 0;
    }

    public void RegisterHit()
    {
        _hit = true;
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
            Debug.Log("CLICKED - PROJ");
            return true;
        }

        return false;
    }

    protected void DestroyProjectile()
    {
        _gameManager.RemoveProjectileFromHitEligibleList(this);
        Debug.Log("Projectile Destroyed");
        Destroy(this.gameObject);
    }

    protected void UpdateHit()
    {
        if (_hit)
        {
            _hit = false;
            _health--;
            Debug.Log("Projectile health - " + _health);
        }
    }

    protected void UpdateSwoon() 
    {
        if (Swoon)
        {
            Debug.Log("Projectile GONE");
            DestroyProjectile();
        }
    }

    protected void CastRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Projectile")
            {
                Debug.Log(hit.collider.gameObject.name);
                _hitEligible = true;
                _gameManager.AddProjectileToHitEligibleList(this);
            }
        }
        else
        {
            Debug.Log("Exited Projectile");
            _hitEligible = false;
            _gameManager.RemoveProjectileFromHitEligibleList(this);
        }
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
