/***********************************
 * ImperfectlyCoded © 2018
 *
 * Hole.h
 ***********************************/
#include <vector>
//#include "BaseMole.h"

/**************************
 * Forward declarations
 **************************/
class BaseMole;

class Hole
{
public:
    /*******************************
     * Constructor(s) / Destructor
     *******************************/
    Hole();
    Hole(int maxOccupancy);
    virtual ~Hole();
    
    /***********************************
     * Occupy
     *
     * Adds a mole to this hole
     *
     * mole - the occupying mole
     ***********************************/
    bool Occupy(const BaseMole* mole);
    
    /***********************************
     * Remove
     *
     * Removes a specific mole from the hole
     *
     * mole - the mole to remove
     ***********************************/
    bool Remove(const BaseMole* mole);
    
    /***********************************
     * MoveInOutHole
     *
     * Removes the last mole added to hole
     ***********************************/
    void Remove();
    
    /***********************************
     * Clear
     *
     * Removes all moles from this hole
     ***********************************/
    void Clear();
    
    /***********************************
     * Empty
     *
     * Moves mole in and out of the hole
     ***********************************/
    bool Empty();
    
protected:
    //
    // Holds the moles that occupy the hole
    std::vector<BaseMole*> m_moles;
    
    //
    // Value of max amount of moles allowed
    int m_maxOccupancy;
}; 

