using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitcherMole : Mole
{
    #region Serialize Fields

    // contains pitch-type prefabs:
    // 0 - Slowball
    // 1 - Fastball
    // 2 - Curveball
    // 3 - Missed pitch northeast (up, right)
    [SerializeField]
    private GameObject[] _pitches;

    #endregion

    #region Constants

    private const int SLOW_BALL = 0;
    private const int FAST_BALL = 1;
    private const int CURVE_BALL = 2;
    private const int MISS_BALL_NE = 3;

    #endregion

    #region Delegates

    private delegate void PitchType();

    #endregion

    #region Fields

    private int _baseballs;
    private PitchType[] _pitchTypes;

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _baseballs = _projectiles;

        _pitchTypes = new PitchType[]
        {
            ThrowSlowball,
            ThrowFastball,
            ThrowCurveball,
            ThrowMissballNE
        };

        GetSunglassesComponent();
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

    #endregion

    protected override void ThrowLogic()
    {
        if (_outMound && _baseballs > 0)
        {
            DetermineAndThrowPitch();
            --_baseballs;
        }
        else if (!_outMound)
        {
            _baseballs = _projectiles;
        }
    }

    private void ThrowSlowball()
    {
        GameObject slowballClone = Instantiate(_pitches[SLOW_BALL], transform.position, Quaternion.identity);
        Debug.Log("Throw slowball");
    }

    private void ThrowFastball()
    {
        Instantiate(_pitches[FAST_BALL], transform.position, Quaternion.identity);
        Debug.Log("Throw fastball");
    }

    private void ThrowCurveball()
    {
        GameObject curveballClone = Instantiate(_pitches[CURVE_BALL], transform.position, Quaternion.identity);
        Debug.Log("Throw curveball");
    }

    private void ThrowMissballNE()
    {
        GameObject missedPitchClone = Instantiate(_pitches[MISS_BALL_NE], transform.position, Quaternion.identity);
        Destroy(missedPitchClone, 0.8f);
        Debug.Log("Throw missball");
    }

    private void DetermineAndThrowPitch()
    {
        if (ThrowIsAccurate())
        {
            int pitch = Random.Range(0, _pitches.Length - 1);
            _pitchTypes[pitch]();
        }
        else
        {
            _pitchTypes[MISS_BALL_NE]();
        }
    }
}
