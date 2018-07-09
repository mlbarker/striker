//-----------------------------------
// ImperfectlyCoded © 2018
//
// BaseState.cpp
//
// The base implementation of all 
// states for the moles.
//-----------------------------------
#include "BaseState.h"
#include "../Moles/BaseMole.h"


BaseState::BaseState()
{
    m_name = "BaseState";
}

BaseState::~BaseState()
{
}

//---------------------------------------------
// Enter()
//
// mole - the mole who is entering the state
// state - the next state
//---------------------------------------------
virtual void Enter(BaseMole* mole, BaseState* state);
{
    std::cout << "Entering state\n";
}

//---------------------------------------------
// Exit()
//
// mole - the mole who is exiting the state
// state - the next state
//---------------------------------------------
virtual void Exit(BaseMole* mole, BaseState* state);
{
    std::cout << "Leaving state\n";
}
