//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// IJob.h
//-----–----------–------------------

//--------------------------
// Forward declarations
//--------------------------
class Mound;

class IJob
{
public:
    //-----------------------------------
    // MoveInMound
    //
    // Moves mole into the mound.
    //-----------------------------------
    virtual void MoveInMound() = 0;
    
    //-----------------------------------
    // MoveOutMound
    //
    // Moves mole out of the mound.
    //-----------------------------------
    virtual void MoveOutMound() = 0;
    
    //-----------------------------------
    // MoveToDifferentMound
    //
    // Moves mole to a different Mound.
    //
    // Mound - the new mound
    //-----------------------------------
    virtual void MoveToDifferentMound(Mound* mound) = 0;
    
    //--------------------------------------
    // ThrowProjectile
    //
    // Triggers mole to throw designated
    // weapon.
    //--------------------------------------
    virtual void Throw() = 0;
    
    //--------------------------------------
    // Counter
    //
    // Triggers the mole to counter attack.
    //--------------------------------------
    virtual void Counter() = 0;
    
    //-------------------------------------------
    // Charge
    //
    // Triggers the mole to charge, then attack.
    //-------------------------------------------
    virtual void Charge() = 0;
    
    //--------------------------------------
    // Evade
    //
    // Triggers the mole to evade attacks.
    //--------------------------------------
    virtual void Evade() = 0;    
};