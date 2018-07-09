//-----------------------------------
// ImperfectlyCoded © 2018
//
// Mole.h
//-----------------------------------
#include <string>
#include "BaseMole.h"

//--------------------------
// Forward declarations
//--------------------------
class Mound;

class Mole : public BaseMole
{
public:
    //-----------------------------------
    // Constructor(s) / Destructor
    //-----------------------------------
    Mole();
    Mole(int health, int stamina, const Mound* mound);
    virtual ~Mole();
    
    //-----------------------------------
    // MoveInMound
    //
    // Moves mole into the mound.
    //-----------------------------------
    virtual void MoveInMound();
    
    //-----------------------------------
    // MoveOutMound
    //
    // Moves mole out of the mound.
    //-----------------------------------
    virtual void MoveOutMound();
    
    //-----------------------------------
    // MoveToDifferentMound
    //
    // Moves mole to a different Mound.
    //
    // Mound - the new mound
    //-----------------------------------
    virtual void MoveToDifferentMound(const Mound* mound);
    
    //-----------------------------------
    // ThrowProjectile
    //
    // Triggers mole to throw designated
    // weapon.
    //-----------------------------------
    void ThrowProjectile();
    
protected:
  
};