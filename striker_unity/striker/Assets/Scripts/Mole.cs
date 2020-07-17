using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    #region SerializeFields

    [SerializeField]
    private bool _outMound = true;

    [SerializeField]
    private float _maxTimeInMound = 3.0f;

    [SerializeField]
    private float _maxTimeOutMound = 5.0f;

    #endregion

    #region Fields

    private float _timeAmount;
    private bool _sunglasses = true;

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
    }

    // Update is called once per frame
    void Update()
    {
        // start a cycle where the mole has 
        // basic logic of going into and 
        // coming out of the mound.
        //
        // just use some basic movement
        // until I have assets
        InOutMoundLogic();
    }

    #endregion

    #region Private Methods

    private void GoIntoMound()
    {
        _outMound = false;
        transform.position = new Vector3(0, -5.0f, 0);
        _timeAmount = Random.Range(2.0f, _maxTimeInMound);
        Debug.Log("In hole time: " + _timeAmount);
    }

    private void GoOutOfMound()
    {
        _outMound = true;
        transform.position = Vector3.zero;
        _timeAmount = Random.Range(2.0f, _maxTimeOutMound);
        Debug.Log("Out hole time: " + _timeAmount);
    }

    private void InOutMoundLogic()
    {
        _timeAmount -= Time.deltaTime;
        if (_timeAmount < 0)
        {
            Debug.Log("Moving: " + _timeAmount);
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

    #endregion
}
