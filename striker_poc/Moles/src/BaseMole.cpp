//------------------------------------
// ImperfectlyCoded © 2018
//
// BaseMole.cpp
//------------------------------------
 #include <iostream>
 #include "../include/BaseMole.h"
 #include "../Holes/Hole.h"
 
//-------------------------------
// Constructor(s) / Destructor
//-------------------------------
BaseMole::BaseMole()
: m_health(0)
, m_stamina(0)
, m_mound(0)
, m_state(0)
, m_type("BaseMole")
{
    std::cout << m_type.c_str() << " created!\n";
}

BaseMole::BaseMole(int health, int stamina, const Mound* mound)
: m_health(health)
, m_stamina(stamina)
, m_mound(mound)
, m_type("BaseMole")
{}

BaseMole::~BaseMole()
{
    m_mound = 0;
    m_state = 0;
}

//---------------------------------------------
// EnterState()
//
// state - the next state to enter
//---------------------------------------------
void BaseMole::EnterState(BaseState* state)
{
}

//---------------------------------------------
// ExitState()
//---------------------------------------------
void BaseMole::ExitState()
{
}
    
//-----------------------------------
// MoveInMound
//
// Moves mole into the mound.
//-----------------------------------
void BaseMole::MoveInMound()
{
    std::cout << m_type.c_str() << " moves into mound\n";
}

//-----------------------------------
// MoveOutMound
//
// Moves mole out of the mound.
//-----------------------------------
void BaseMole::MoveOutMound()
{
    std::cout << m_type.c_str() << " moves out of mound\n";
}

//-------------------------------------
// MoveToDifferentMound
//
// Moves mole to a different mound.
//
// mound - the new mound
//-------------------------------------
void BaseMole::MoveToDifferentMound(const Mound* mound)
{
    std::cout << m_type.c_str() << " moving to a different mound\n";
}

void BaseMole::ThrowProjectile()
{
    std::cout << m_type.c_str() << " throws a projectile\n";
}
    
void BaseMole::CounterAttack()
{
    std::cout << m_type.c_str() << " counter attacks\n";
}

void BaseMole::ChargeAttack()
{
    std::cout << m_type.c_str() << " charges to attack\n";
}

void BaseMole::EvadeAttack()
{
    std::cout << m_type.c_str() << " evades attack\n";
}

/***********************************
 * AdjustStamina
 *
 * Increments/Decrements stamina by 
 * change amount.
 *
 * changeAmt - the amount to increment
 *           or decrement stamina.
 ***********************************/
void BaseMole::AdjustStamina(int changeAmt)
{
    //m_health += changeAmt;
    std::cout << m_type.c_str() << " stamina was adjusted\n";
}

/***********************************
 * AdjustHealth
 *
 * Increments/Decrements health by 
 * change amount.
 *
 * changeAmt - the amount to increment
 *           or decrement health.
 ***********************************/
void BaseMole::AdjustHealth(int changeAmt)
{
    //m_stamina += changeAmt;
    std::cout << m_type.c_str() << " health was adjusted\n";
}