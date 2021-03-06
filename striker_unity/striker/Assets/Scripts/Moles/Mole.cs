﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    #region Serialize Fields

    [SerializeField]
    protected int _health = 1;

    [SerializeField]
    private GameObject [] _projectilePrefabs; // assigned in editor

    [SerializeField]
    protected bool _outMound = true;

    [SerializeField]
    protected float _maxTimeInMound = 3.0f;

    [SerializeField]
    protected float _maxTimeOutMound = 5.0f;

    [SerializeField]
    protected float _throwAccuracy = 0.7f;

    [SerializeField]
    protected float _sunglassesDropPercentage = 0.1f;

    // the amount of projectiles the mole will
    // throw before going into the mound
    [SerializeField]
    protected int _projectiles = 1;

    #endregion

    #region Constants

    private const int ROCK = 0;
    private const int ROCK_MISSED_NW = 1;

    #endregion

    #region Fields

    protected Sunglasses _sunglasses;
    protected float _timeAmount;
    protected bool _sunglassesOn = true;
    protected float _noSunglassesAccuracy;
    protected bool _hitEligible = false;
    protected bool _hit = false;
    protected int _moddedHealth;
    private int _rocks;

    #endregion

    #region Properties

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

    public bool Swoon
    {
        get => _moddedHealth <= 0;
    }

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        // for testing only - out of mound
        gameObject.SetActive(_outMound);
        
        if (_outMound)
        {
            _timeAmount = Random.Range(2.0f, _maxTimeOutMound);
        }
        else
        {
            _timeAmount = Random.Range(2.0f, _maxTimeInMound);
        }

        GetSunglassesComponent();

        _rocks = _projectiles;
        _moddedHealth = _health;
    }

    // Update is called once per frame
    void Update()
    {
        InOutMoundLogic();
        ThrowLogic();
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

    #endregion

    #region Public Methods

    public void RegisterHit()
    {
        SunglassesDroppedDetermination();

        _hit = true;
    }

    #endregion

    #region Protected Methods

    protected void GetSunglassesComponent()
    {
        _sunglasses = this.GetComponentInChildren<Sunglasses>();
        if (_sunglasses == null)
        {
            Debug.LogError("Mole.Start()._sunglasses is null");
        }
        else
        {
            _noSunglassesAccuracy += _throwAccuracy + _sunglasses.AccuracyDrop;
            Debug.Log("No sunglasses accuracy = " + _noSunglassesAccuracy);
        }
    }

    protected void GoIntoMound()
    {
        _outMound = false;
        transform.position += new Vector3(0, -5.0f, 0);
        _timeAmount = Random.Range(2.0f, _maxTimeInMound);
    }

    protected void GoOutOfMound()
    {
        _outMound = true;
        transform.position += new Vector3(0, 5.0f, 0);
        _timeAmount = Random.Range(2.0f, _maxTimeOutMound);
    }

    protected void InOutMoundLogic()
    {
        _timeAmount -= Time.deltaTime;
        if (_timeAmount < 0)
        {
            if (_outMound)
            {
                GoIntoMound();
            }
            else
            {
                GoOutOfMound();
            }
        }
    }

    protected virtual void ThrowLogic()
    {
        if (_outMound && _rocks > 0)
        {
            ThrowRock();
            _rocks--;
        }
        else if (!_outMound)
        {
            _rocks = _projectiles;
        }
    }

    protected bool ThrowIsAccurate()
    {
        float accuracy = Random.Range(0.0f, 1.0f);
        return (_sunglasses) ? accuracy <= _throwAccuracy : accuracy <= _noSunglassesAccuracy;
    }

    protected void UpdateHit()
    {
        if (_hit)
        {
            _hit = false;
            _moddedHealth--;
            Debug.Log("Health - " + _moddedHealth);
        }
    }

    protected void UpdateSwoon()
    {
        if (Swoon)
        {
            // return to the mound and update health
            _moddedHealth = _health;
            GoIntoMound();

            Debug.Log(this.name + " GONE!");
        }
    }

    protected void CastRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Mole")
            {
                Debug.Log(hit.collider.gameObject.name);
                _hitEligible = true;
            }
        }
        else
        {
            Debug.Log("Exited Mole");
            _hitEligible = false;
        }
    }

    protected void SunglassesDroppedDetermination()
    {
        if (_sunglassesOn)
        {
            float randomPercentage = Random.Range(0.0f, 1.0f);
            Debug.Log("Rando Percent|" + randomPercentage);
            if (randomPercentage <= _sunglassesDropPercentage)
            {
                _sunglassesOn = false;
                _sunglasses.gameObject.SetActive(_sunglassesOn);
            }
        }
    }

    #endregion

    #region Private Methods

    private void ThrowRock()
    {
        GameObject rockClone;
        if (ThrowIsAccurate())
        {
            rockClone = Instantiate(_projectilePrefabs[ROCK], transform.position, Quaternion.identity);
        }
        else
        {
            rockClone = Instantiate(_projectilePrefabs[ROCK_MISSED_NW], transform.position, Quaternion.identity);
        }
        // TODO: IMPLEMENT
        // else
        // 1 - throw rock with inaccuracy
        //  A - to do this we have to change _projectilePrefab to an array of GameObjects
        //  B - set the prefabs in the editor
    }

    #endregion
}
