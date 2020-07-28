using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    #region Serialize Fields

    [SerializeField]
    private GameObject _projectilePrefab; // assigned in editor

    [SerializeField]
    protected bool _outMound = true;

    [SerializeField]
    protected float _maxTimeInMound = 3.0f;

    [SerializeField]
    protected float _maxTimeOutMound = 5.0f;

    [SerializeField]
    protected float _throwAccuracy = 0.7f;

    // the amount of projectiles the mole will
    // throw before going into the mound
    [SerializeField]
    protected int _projectiles = 1;

    #endregion

    #region Fields

    protected float _timeAmount;
    protected bool _sunglasses = true;
    protected float _noSunglassesAccuracy = 0.35f;
    private int _rocks;

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

        _rocks = _projectiles;
    }

    // Update is called once per frame
    void Update()
    {
        InOutMoundLogic();
        ThrowLogic();
    }

    #endregion

    #region Protected Methods

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

    #endregion

    #region Private Methods

    private void ThrowRock()
    {
        GameObject rockClone = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
        Destroy(rockClone, 1.0f);
    }

    #endregion
}
