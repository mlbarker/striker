//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Pitcher.h
//-----–----------–------------------
class Pitcher : public IJob
{
public:
    //-----–----------–------------------
    // Constructors / Destructor
    //-----–----------–------------------
    Pitcher();
    virtual ~Pitcher();
    
    //-----------------------------------
    // MoveInMound
    //
    // Moves mole into the mound.
    //-----------------------------------
    void MoveInMound();
    
    //-----------------------------------
    // MoveOutMound
    //
    // Moves mole out of the mound.
    //-----------------------------------
    void MoveOutMound();
    
    //-----------------------------------
    // MoveToDifferentMound
    //
    // Moves mole to a different Mound.
    //
    // Mound - the new mound
    //-----------------------------------
    void MoveToDifferentMound(Mound* mound);
    
    //--------------------------------------
    // ThrowProjectile
    //
    // Triggers mole to throw designated
    // weapon.
    //--------------------------------------
    void Throw();
    
    //--------------------------------------
    // Counter
    //
    // Triggers the mole to counter attack.
    //--------------------------------------
    void Counter();
    
    //-------------------------------------------
    // Charge
    //
    // Triggers the mole to charge, then attack.
    //-------------------------------------------
    void Charge();
    
    //--------------------------------------
    // Evade
    //
    // Triggers the mole to evade attacks.
    //--------------------------------------
    void Evade();
};