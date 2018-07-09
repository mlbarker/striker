//-----–----------–------------------
// ImperfectlyCoded © 2018
//-----–----------–------------------
#include <string>

//--------------------------
// Forward declarations
//--------------------------
class Mound;
class BaseState;
class IJob;

class BaseMole
{
public:
    //-------------------------------
    // Constructor(s) / Destructor
    //-------------------------------
    BaseMole();
    BaseMole(int health, int stamina, const Mound* mound);
    virtual ~BaseMole();
    
    //---------------------------------------------
    // Initialize()
    //---------------------------------------------
    virtual void Initialize();
    
    //---------------------------------------------
    // EnterState()
    //
    // state - the next state to enter
    //---------------------------------------------
    virtual void EnterState(BaseState* state);
    
    //---------------------------------------------
    // ExitState()
    //---------------------------------------------
    virtual void ExitState();
    
    
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
    
    //--------------------------------------
    // Counter
    //
    // Triggers the mole to counter attack.
    //--------------------------------------
    virtual void Counter();
    
    //-------------------------------------------
    // Charge
    //
    // Triggers the mole to charge, then attack.
    //-------------------------------------------
    virtual void Charge();
    
    //--------------------------------------
    // Evade
    //
    // Triggers the mole to evade attacks.
    //--------------------------------------
    virtual void Evade();
    
    //--------------------------------------
    // AdjustStamina
    //
    // Increments/Decrements stamina by 
    // change amount.
    //
    // changeAmt - the amount to increment
    //           or decrement stamina.
    //--------------------------------------
    virtual void AdjustStamina(int changeAmt);
    
    //--------------------------------------
    // AdjustHealth
    //
    // Increments/Decrements health by 
    // change amount.
    //
    // changeAmt - the amount to increment
    //           or decrement health.
    //--------------------------------------
    virtual void AdjustHealth(int changeAmt);
    
    //--------------------------------------
    // ThrowProjectile
    //
    // Triggers mole to throw designated
    // weapon.
    //--------------------------------------
    virtual void ThrowProjectile() = 0;
    
    //--------------------------------------
    // SetState
    //
    // Sets the next state
    //--------------------------------------
    virtual void SetState(BaseState* state);
    
protected:
    //
    // the mole's health
    int m_health;
    
    //
    // the mole's stamina
    int m_stamina;
    
    //
    // the occupied mound
    Mound* m_mound;
    
    //
    // the mole type
    std::string m_type;
    
    //
    // the current state
    BaseState* m_state;
    
    //
    // the current job
    IJob* m_job;
};