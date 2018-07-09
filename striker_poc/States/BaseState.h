//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseState.h
//-----–----------–------------------
 
//----------------------
// Forward declarations
//----------------------
class BaseMole;

class BaseState
{
public:
    BaseState();
    virtual ~BaseState();
    
    //---------------------------------------------
    // Action()
    //
    // mole - the mole who is performing the state
    //---------------------------------------------
    virtual void Action(BaseMole* mole) = 0;
    
    //---------------------------------------------
    // Enter()
    //
    // mole - the mole who is entering the state
    // state - the next state
    //---------------------------------------------
    virtual void Enter(BaseMole* mole, BaseState* state);
    
    //---------------------------------------------
    // Exit()
    //
    // mole - the mole who is exiting the state
    // state - the next state
    //---------------------------------------------
    virtual void Exit(BaseMole* mole, BaseState* state);

protected:

    //
    // the state name
    std::string m_name;    
};



