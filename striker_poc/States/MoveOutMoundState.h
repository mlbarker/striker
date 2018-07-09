//------------------------------------
// ImperfectlyCoded © 2018
//
// BaseState.cpp
//------------------------------------
#include "BaseState.h"
 
class MoveOutOfHoleState : public BaseState
{
public:
    MoveOutOfHoleState();
    virtual ~MoveOutOfHoleState();
    
    //---------------------------------------------
    // Action()
    //
    // mole - the mole who is performing the state
    //---------------------------------------------
    virtual void Action(BaseMole* mole);
};