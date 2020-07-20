using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    #region Serialize Fields

    [SerializeField]
    private int _health = 1;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion
}
