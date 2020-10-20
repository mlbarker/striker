using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Implement this to manage the states in the game.
    // Currently, use this as the central hub for determining
    // which GameObject was clicked on projectiles will always
    // be on the top layer followed by the moles then every-
    // thing else.

    #region Serialize Fields

    #endregion

    #region Fields

    private Player _player;
    private List<Mole> _molesInLevel;
    private List<Mole> _hitEligibleMoles;
    private List<Projectile> _hitEligibleProjectiles;

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (_player == null)
        {
            Debug.LogError("GameManager._player is NULL");
        }

        // OnLevelStart() will be moved once I implement
        // separate scenes.
        OnLevelStart();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerClickDetermination();
        UpdateHitEligibleLists();
    }

    #endregion

    #region Public Methods

    public void AddProjectileToHitEligibleList(Projectile projectile)
    {
        if (projectile == null)
        {
            Debug.LogError("GameManager.AddProjectileToHightEligibleList() - projectile is null");
        }
        else
        {
            _hitEligibleProjectiles.Add(projectile);
        }
    }

    public void RemoveProjectileFromHitEligibleList(Projectile projectile)
    {
        _hitEligibleProjectiles.Remove(projectile);
    }

    #endregion

    #region Private Methods

    private void OnLevelStart()
    {
        if (_molesInLevel == null)
        {
            _molesInLevel = new List<Mole>();
        }

        if (_hitEligibleMoles == null)
        {
            _hitEligibleMoles = new List<Mole>();
        }

        if (_hitEligibleProjectiles == null)
        {
            _hitEligibleProjectiles = new List<Projectile>();
        }

        var moleGameObjects = GameObject.FindGameObjectsWithTag("Mole");
        foreach (var moleGameObject in moleGameObjects)
        {
            var mole = moleGameObject.GetComponent<Mole>();
            if (mole == null)
            {
                Debug.LogError("GameManager.OnLevelStart() - mole is null");
                Debug.LogError("moleGameObject.GetComponent<Mole>() failed!");
            }
            else
            {
                _molesInLevel.Add(mole);
            }
        }

        Projectile.ResetIdCounter();
    }

    private void UpdateHitEligibleLists()
    {
        UpdateHitEligibleMoles();
        UpdateHitEligibleProjectiles();
    }

    private void UpdateHitEligibleMoles()
    {
        _hitEligibleMoles.Clear();

        foreach (var mole in _molesInLevel)
        {
            if (mole.HitEligible)
            {
                _hitEligibleMoles.Add(mole);
            }
        }
    }

    private void UpdateHitEligibleProjectiles()
    {
        // exit if the list is empty
        if (_hitEligibleProjectiles.Count != 0)
        {
            // just error checking at this point since 
            // the projectiles take care of themselves
            foreach (var projectile in _hitEligibleProjectiles)
            {
                if (projectile == null)
                {
                    _hitEligibleProjectiles.Remove(projectile);
                }
            }
        }
    }

    private void PlayerClickDetermination()
    {
        if (_player.MouseClicked())
        {
            // lastProjectileIndex and lastMoleIndex refers to the 
            // projectile/mole drawn on the topmost layer
            //      NOTE: it is possible that a projectile or mole
            //      on a lower layer could take the hit so this is
            //      this is definitely a potential issue to watch for
            if (_hitEligibleProjectiles.Count != 0)
            {
                int lastProjectileIndex = _hitEligibleProjectiles.Count - 1;
                _hitEligibleProjectiles[lastProjectileIndex].RegisterHit();
            }
            else if (_hitEligibleMoles.Count != 0)
            {
                int lastMoleIndex = _hitEligibleMoles.Count - 1;
                _hitEligibleMoles[lastMoleIndex].RegisterHit();
            }

        }
    }

    #endregion
}
