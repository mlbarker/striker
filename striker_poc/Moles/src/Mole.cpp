//-----------------------------------
// ImperfectlyCoded © 2018
//
// Mole.cpp
//-----------------------------------
#include <iostream>
#include "Mole.h"
#include "../Mounds/Mound.h"

Mole::Mole()
: BaseMole()
{
    m_type = "Mole";
}

Mole::Mole(int health, int stamina, const Hole* hole)
: BaseMole(health, stamina, hole)
{
    m_type = "Mole";
}

//--–-------------------------------
// MoveInMound
//
// Moves mole into the mound.
//--–-------------------------------
void Mole::MoveInMound()
{
    std::cout << m_type << " moves into mound!\n";
}

//--–-------------------------------
// MoveOutMound
//
// Moves mole out of the mound.
//--–-------------------------------
void Mole::MoveOutMound()
{
    std::cout << m_type << " moves out of mound!\n";
}

//--–-------------------------------
// MoveToDifferentMound
//
// Moves mole to a different mound.
//
// mound - the new mound
//--–-------------------------------
void Mole::MoveToDifferentMound(const Mound* mound)
{
}

//--–-------------------------------
// ThrowProjectile
//
// Triggers mole to throw designated
// weapon.
//--–-------------------------------
void Mole::ThrowProjectile()
{
}